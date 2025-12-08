// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.IO;
using System.Windows;
using System.Windows.Controls;

using WinForms = System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace RockDbBackupManager
{
    public partial class MainWindow : Window
    {
        // Connection string for listing databases and backup/restore operations (SQL Server Authentication)
        private readonly string masterConnectionString = "Server=localhost;Database=master;User Id=RockUser;Password=E2mufCzpNVZBZOzTijSB0qLeAQsaUi96LXPpW5wpTtPz5JYkAgJpyZjUCI9M18bOFKOFlzin3rHhcjOhTS24V3xopRXLA2CdqYlEq4QQ2wx26l9aYlBT2QfUSK4Qf4n9;TrustServerCertificate=True;MultipleActiveResultSets=true";
        
        public MainWindow()
        {
            InitializeComponent();
            // Load backup directory from settings or use default
            string savedDir = BackupManager.Default.BackupDirectory;
            if (!string.IsNullOrWhiteSpace(savedDir) && System.IO.Directory.Exists(savedDir))
            {
                BackupDirectoryTextBox.Text = savedDir;
            }
            else
            {
                BackupDirectoryTextBox.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\Backup\\";
            }
            LoadDatabaseNames();
            var dbName = DatabaseNameComboBox.SelectedItem as string;
            LoadBackupFiles(dbName);
        }

        private void LoadDatabaseNames()
        {
            try
            {
                var databases = new List<string>();
                using (var connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            databases.Add(reader.GetString(0));
                        }
                    }
                }
                DatabaseNameComboBox.ItemsSource = databases;
                if (databases.Count > 0)
                    DatabaseNameComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                StatusTextBlock.Text = $"Error loading databases: {ex.Message}";
            }
        }

        private void LoadBackupFiles(string filterDbName = null)
        {
            var backupDir = BackupDirectoryTextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(backupDir) && System.IO.Directory.Exists(backupDir))
            {
                var files = Directory.GetFiles(backupDir, "*.bak");
                var fileNames = files.Select(f => Path.GetFileName(f)).ToList();
                if (!string.IsNullOrWhiteSpace(filterDbName))
                {
                    fileNames = fileNames.Where(f => f.Contains(filterDbName, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                BackupFilesListBox.ItemsSource = fileNames;
            }
            else
            {
                BackupFilesListBox.ItemsSource = null;
            }
        }
        
        private void SetStatus(string message, bool isError = false, bool isLoading = false)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StatusTextBlock.Text = $"[{timestamp}] {message}{(isLoading ? " ..." : "")}";
            StatusTextBlock.Foreground = isError ? System.Windows.Media.Brushes.Red : System.Windows.Media.Brushes.Black;
        }

        private void SetUiEnabled(bool enabled)
        {
            DatabaseNameComboBox.IsEnabled = enabled;
            BackupDirectoryTextBox.IsEnabled = enabled;
            BrowseBackupDirectoryButton.IsEnabled = enabled;
            AdditionalTagsTextBox.IsEnabled = enabled;
            BackupButton.IsEnabled = enabled;
            RestoreButton.IsEnabled = enabled;
            BrowseRestoreFileButton.IsEnabled = enabled;
            BackupFilesListBox.IsEnabled = enabled;
        }
        private void DatabaseNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dbName = DatabaseNameComboBox.SelectedItem as string;
            LoadBackupFiles(dbName);
        }

        private void BackupFilesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BackupFilesListBox.SelectedItem is string selectedFile)
            {
                RestoreFileTextBox.Text = selectedFile;
            }
        }

        private void BrowseRestoreFileButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*",
                Title = "Select backup file to prepare for restore",
                Multiselect = false
            };
            // If RestoreFileTextBox is empty, use BackupDirectoryTextBox as initial directory
            var restoreFilePath = RestoreFileTextBox.Text.Trim();
            string initialDir = null;
            if (!string.IsNullOrWhiteSpace(restoreFilePath) && System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(restoreFilePath)))
            {
                initialDir = Path.GetDirectoryName(restoreFilePath);
            }
            else if (!string.IsNullOrWhiteSpace(BackupDirectoryTextBox.Text) && System.IO.Directory.Exists(BackupDirectoryTextBox.Text.Trim()))
            {
                initialDir = BackupDirectoryTextBox.Text.Trim();
            }
            if (!string.IsNullOrWhiteSpace(initialDir))
            {
                openFileDialog.InitialDirectory = initialDir;
            }
            if (openFileDialog.ShowDialog() == WinForms.DialogResult.OK)
            {
                RestoreFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private async void BackupButton_Click(object sender, RoutedEventArgs e)
        {

            string dbName = DatabaseNameComboBox.SelectedItem as string;
            string backupDir = BackupDirectoryTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupDir))
            {
                SetStatus("Database name and backup directory are required.", isError: true);
                return;
            }

            string timestamp = DateTime.Now.ToString("yyyy_MM_dd_HHmmss");
            string tags = AdditionalTagsTextBox?.Text ?? string.Empty;
            string tagPart = string.Empty;
            if (!string.IsNullOrWhiteSpace(tags))
            {
                var tagList = tags.Split(',')
                                  .Select(t => t.Trim())
                                  .Where(t => !string.IsNullOrWhiteSpace(t))
                                  .Select(t => System.Text.RegularExpressions.Regex.Replace(t, "[^a-zA-Z0-9]", ""))
                                  .Where(t => !string.IsNullOrWhiteSpace(t))
                                  .ToList();
                if (tagList.Count > 0)
                {
                    tagPart = "-" + string.Join("_", tagList);
                }
            }
            string backupFileName = $"{timestamp}-{dbName}{tagPart}.bak";
            string backupPath = System.IO.Path.Combine(backupDir, backupFileName);

            string sql = $@"BACKUP DATABASE [{dbName}] TO DISK = N'{backupPath}' WITH COPY_ONLY, NOFORMAT, INIT, NAME = N'{backupFileName}', SKIP, NOREWIND, NOUNLOAD, STATS = 20, CHECKSUM;";

            SetStatus("Backup started", isError: false, isLoading: true);
            SetUiEnabled(false);
            try
            {
                await Task.Run(() =>
                {
                    using (var connection = new SqlConnection(masterConnectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.CommandTimeout = 0;
                            command.ExecuteNonQuery();
                        }
                    }
                });
                SetStatus($"Backup completed: {backupPath}");
                LoadBackupFiles(dbName); // Refresh restore list after backup
                RestoreFileTextBox.Text = string.Empty;
            }
            catch (SqlException ex)
            {
                SetStatus($"SQL error during backup: {ex.Message}", isError: true);
            }
            catch (Exception ex)
            {
                SetStatus($"Backup failed: {ex.Message}", isError: true);
            }
            finally
            {
                SetUiEnabled(true);
            }
        }

        private async void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            string dbName = DatabaseNameComboBox.SelectedItem as string;
            string restoreFile = RestoreFileTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(restoreFile))
            {
                SetStatus("Database name and restore file are required.", isError: true);
                return;
            }

            // Show warning if enabled
            if (BackupManager.Default.IsWarningOnRestore)
            {
                var result = System.Windows.MessageBox.Show(
                    "Restoring will completely overwrite the current contents of the selected database. Backups created or restored with this application are full, copy-only backups.\n\nHit cancel to stop the restore, but also never display this message again (not recommended, but you are the captain of your own ship.)\n\nDo you want to continue?",
                    "Restore Warning",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Warning,
                    MessageBoxResult.No);

                // Custom handling for 'Don't Warn Me Again'
                // Since MessageBox doesn't support custom buttons, treat Cancel as 'Don't Warn Me Again'
                if (result == MessageBoxResult.Cancel)
                {
                    BackupManager.Default.IsWarningOnRestore = false;
                    BackupManager.Default.Save();
                    // Ask again for confirmation
                    var confirm = System.Windows.MessageBox.Show(
                        "Do you want to continue with the restore?",
                        "Confirm Restore",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question,
                        MessageBoxResult.No);
                    if (confirm != MessageBoxResult.Yes)
                        return;
                }
                else if (result != MessageBoxResult.Yes)
                {
                    // User chose No or closed dialog
                    return;
                }
            }

            string sql = $@"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [{dbName}] FROM DISK = N'{restoreFile}' WITH REPLACE; ALTER DATABASE [{dbName}] SET MULTI_USER;";

            SetStatus("Restore started", isError: false, isLoading: true);
            SetUiEnabled(false);
            try
            {
                await Task.Run(() =>
                {
                    using (var connection = new SqlConnection(masterConnectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.CommandTimeout = 0;
                            command.ExecuteNonQuery();
                        }
                    }
                });
                SetStatus($"Restore completed: {restoreFile}");
            }
            catch (SqlException ex)
            {
                SetStatus($"SQL error during restore: {ex.Message}", isError: true);
            }
            catch (Exception ex)
            {
                SetStatus($"Restore failed: {ex.Message}", isError: true);
            }
            finally
            {
                SetUiEnabled(true);
            }
        }
        private void BrowseBackupDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            var initialDir = BackupDirectoryTextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(initialDir) && System.IO.Directory.Exists(initialDir))
            {
                dialog.InitialDirectory = initialDir;
            }
            if (dialog.ShowDialog() == WinForms.DialogResult.OK)
            {
                var folder = dialog.SelectedPath;
                BackupDirectoryTextBox.Text = folder;

                // Save to settings
                BackupManager.Default.BackupDirectory = folder;
                BackupManager.Default.Save();

                var dbName = DatabaseNameComboBox.SelectedItem as string;
                LoadBackupFiles(dbName); // Refresh backup files list filtered by selected DB
            }
        }

        private void DeleteBackupButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Button btn && btn.Tag is string fileName)
            {
                var backupDir = BackupDirectoryTextBox.Text.Trim();
                var filePath = System.IO.Path.Combine(backupDir, fileName);
                if (!System.IO.File.Exists(filePath))
                {
                    System.Windows.MessageBox.Show($"File not found: {filePath}", "Delete Backup", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var result = System.Windows.MessageBox.Show($"Are you sure you want to permanently delete '{fileName}'? This action cannot be undone.", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        System.IO.File.Delete(filePath);
                        var dbName = DatabaseNameComboBox.SelectedItem as string;
                        LoadBackupFiles(dbName);
                        RestoreFileTextBox.Text = string.Empty;
                        SetStatus($"Deleted backup: {fileName}");
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.MessageBox.Show($"Failed to delete file: {ex.Message}", "Delete Backup", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void RestoreWarningMenuItem_Click(object sender, RoutedEventArgs e)
        {
            BackupManager.Default.IsWarningOnRestore = true;
            BackupManager.Default.Save();
            System.Windows.MessageBox.Show(
                "Restore warning has been reset and will be shown before future restores.",
                "Restore Warning Reset",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            string info = "RockDB Backup Manager\n\n" +
                "Copyright © Spark Development Network\n" +
                "Licensed under the Rock Community License\n" +
                "https://www.rockrms.com/license\n\n" +
                "This core developer tool allows you to create and restore full, copy-only SQL Server backups for Rock RMS databases.";
            System.Windows.MessageBox.Show(info, "About RockDB Backup Manager", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}