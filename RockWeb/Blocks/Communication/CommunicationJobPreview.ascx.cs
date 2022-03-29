﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rock;
using Rock.Attribute;
using Rock.Communication;
using Rock.Data;
using Rock.Model;
using Rock.Web.Cache;
using Rock.Web.UI;
using Rock.Web.UI.Controls;

namespace RockWeb.Blocks.Communication
{
    [DisplayName( "System Communication Preview" )]
    [Category( "Communication" )]
    [Description( "Create a preview and send a test message for the given system communication using the selected date and target person." )]

    #region Block Attributes

    [SystemCommunicationField( "System Communication",
        Description = "The system communication to use when previewing the message. When set as a block setting, it will not allow overriding by the query string.",
        IsRequired = false,
        Order = 0,
        Key = AttributeKey.SystemCommunication )]

    [DaysOfWeekField( "Send Day of the Week",
        Description = "Used to determine which dates to list in the Message Date drop down. <i><strong>Note:</strong> If no day is selected the Message Date drop down will not be shown and the ‘SendDateTime’ Lava variable will be set to the current day.</i>",
        IsRequired = false,
        Order = 1,
        Key = AttributeKey.SendDaysOfTheWeek )]

    [IntegerField( "Number of Previous Weeks to Show",
        Description = "How many previous weeks to show in the drop down.",
        DefaultIntegerValue = 6,
        Order = 3,
        Key = AttributeKey.PreviousWeeksToShow )]

    [IntegerField( "Number of Future Weeks to Show",
        Description = "How many weeks ahead to show in the drop down.",
        DefaultIntegerValue = 1,
        Order = 4,
        Key = AttributeKey.FutureWeeksToShow )]

    [LavaCommandsField( "Enabled Lava Commands",
        Description = "The Lava commands that should be enabled.",
        IsRequired = false,
        Key = AttributeKey.EnabledLavaCommands,
        Order = 5 )]
    #endregion Block Attributes

    public partial class CommunicationJobPreview : RockBlock
    {
        #region Fields

        internal bool HasSendDate { get; set; }
        internal bool HasSystemCommunication = false;
        internal bool HasTargetPerson = false;
        #endregion

        #region Page Constants
        private static class PageConstants
        {
            public const string LavaDebugCommand = "{{ 'Lava' | Debug }}";

            public const string EmailContainerHtml = @"
                                <div id='divEmailPreview'
                                    class='email-preview js-email-preview overflow-auto' style='position: relative; height: 720px;'>
                                    <iframe name='emailPreview' src='javascript: window.frameElement.getAttribute('srcdoc');'
                                        id='ifEmailPreview' name='emailpreview-iframe'
                                        class='emaileditor-iframe js-emailpreview-iframe email-wrapper email-content-desktop styled-scroll' frameborder='0' border='0' cellspacing='0'
                                        scrolling='no' srcdoc='[SOURCE_REPLACEMENT]''></iframe>
                                    <div class='resize-sensor'
                                        style='position: absolute; inset: 0px; overflow: scroll; z-index: -1; visibility: hidden;'>
                                        <div class='resize-sensor-expand'
                                            style='position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: scroll; z-index: -1; visibility: hidden;'>
                                            <div style='position: absolute; left: 0px; top: 0px; width: 388px; height: 574px;'></div>
                                        </div>
                                        <div class='resize-sensor-shrink'
                                            style='position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: scroll; z-index: -1; visibility: hidden;'>
                                            <div style='position: absolute; left: 0; top: 0; width: 200%; height: 200%'></div>
                                        </div>
                                    </div>
                                </div>";
            public const string SystemCommunicationSourceReplacementKey = "[SOURCE_REPLACEMENT]";
        }
        #endregion

        #region Page Parameter Keys

        private static class PageParameterKey
        {
            public const string SystemCommunicationId = "SystemCommunicationId";
            public const string PublicationDate = "PublicationDate";
            public const string TargetPersonId = "TargetPersonId";
        }

        #endregion Page Parameter Keys

        #region Attribute Keys

        private static class AttributeKey
        {
            public const string SystemCommunication = "SystemCommunication";
            public const string SendDaysOfTheWeek = "SendDaysOfTheWeek";
            public const string PreviousWeeksToShow = "PreviousWeeksToShow";
            public const string FutureWeeksToShow = "FutureWeeksToShow";
            public const string EnabledLavaCommands = "EnabledLavaCommands";
        }

        #endregion Attribute Keys

        #region Merge Field Keys

        private static class MergeFieldKey
        {
            public const string SendDateTime = "SendDateTime";
            public const string Person = "Person";
        }

        #endregion Merge Field Keys

        #region ViewState Keys

        private static class ViewStateKey
        {
            public const string SystemCommunicationGuid = "SystemCommunicationGuid";
            public const string TargetPersonId = "TargetPersonId";
            public const string SelectedDate = "SelectedDate";
        }

        #endregion ViewState Keys

        #region Page Events
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            BuildUI();
        }

        #endregion Page Events

        #region Control Events

        /// <summary>
        /// Handles the Click event of the lbUpdate control.
        /// </summary>
        protected void lbUpdate_Click( object sender, EventArgs e )
        {
            var mergeInfo = BuildSystemCommunication();

            var source = mergeInfo.RockEmailMessageRecord.Message
                .ResolveMergeFields( mergeInfo.MergeFields, null, EnabledLavaCommands )
                .ConvertHtmlStylesToInlineAttributes()
                .EncodeHtml();

            lContent.Text = PageConstants.EmailContainerHtml.Replace( PageConstants.SystemCommunicationSourceReplacementKey, source );
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ddlMessageDate control.
        /// </summary>
        protected void ddlMessageDate_SelectedIndexChanged( object sender, EventArgs e )
        {
            ViewState[ViewStateKey.SelectedDate] = ddlMessageDate.SelectedIndex;
            HasSendDate = ViewState[ViewStateKey.SelectedDate].ToIntSafe() > 0;

            UpdateSendDateUrlParam();
        }

        /// <summary>
        /// Handles the SelectPerson event of the ppTargetPerson control.
        /// </summary>
        protected void ppTargetPerson_SelectPerson( object sender, EventArgs e )
        {
            var targetPersonValue = ppTargetPerson.SelectedValue.GetValueOrDefault( 0 );
            if ( targetPersonValue > 0 )
            {
                ViewState[ViewStateKey.TargetPersonId] = targetPersonValue;
            }

            UpdateTargetPersonUrlParam( targetPersonValue );
        }

        /// <summary>
        /// Handles the Click event of the btnSendEmail control.
        /// </summary>
        protected void btnSendEmail_Click( object sender, EventArgs e )
        {
            nbSendTest.Visible = false;
            mdSendTest.Show();
            ebSendTest.Text = CurrentPerson.Email;
        }

        /// <summary>
        /// Handles the SaveClick event of the mdSendTest control.
        /// </summary>
        protected void mdSendTest_SaveClick( object sender, EventArgs e )
        {
            string currentEmail = CurrentPerson.Email;
            using ( var rockContext = new RockContext() )
            {
                rockContext.WrapTransactionIf( () =>
                {
                    try
                    {
                        var mergeInfo = BuildSystemCommunication();

                        var rockEmailMessage = mergeInfo.RockEmailMessageRecord;

                        if ( rockEmailMessage == null )
                        {
                            throw new Exception( $"A valid system communication was not selected." );
                        }

                        if ( rockEmailMessage.SystemCommunicationId.GetValueOrDefault( 0 ) == 0 )
                        {
                            throw new Exception( $"The system communication specified is not valid." );
                        }

                        var emailPerson = new PersonService( rockContext ).Get( CurrentPerson.Id );

                        // Remove the lava debug command if it is specified in the message template.
                        var message = rockEmailMessage.Message.Replace( PageConstants.LavaDebugCommand, string.Empty );

                        rockEmailMessage.AdditionalMergeFields = mergeInfo.MergeFields.ToDictionary( k => k.Key, v => ( object ) v.Value );
                        rockEmailMessage.CurrentPerson = emailPerson;
                        rockEmailMessage.Message = message;

                        var sendErrorMessages = new List<string>();

                        // Set person email to the email specified in the dialog
                        emailPerson.Email = ebSendTest.Text;
                        rockContext.SaveChanges();

                        var recipient = new RockEmailMessageRecipient( emailPerson, mergeInfo.MergeFields );
                        rockEmailMessage.AddRecipient( recipient );
                        rockEmailMessage.Send( out sendErrorMessages );

                        if ( sendErrorMessages.Count == 0 )
                        {
                            nbSendTest.Text = $"Email submitted to <i>{recipient.EmailAddress}</i>";
                            nbSendTest.NotificationBoxType = NotificationBoxType.Info;
                            nbSendTest.Visible = true;
                        }
                        else
                        {
                            var errorString = $"<ul>[ERRORS]</ul>";
                            var sbError = new StringBuilder();

                            foreach ( var error in sendErrorMessages )
                            {
                                sbError.AppendLine( $"<li>{error}</li>" );
                            }

                            errorString = errorString.Replace( "[ERRORS]", sbError.ToString() );

                            nbSendTest.Text = errorString;
                            nbSendTest.NotificationBoxType = NotificationBoxType.Danger;
                            nbSendTest.Visible = true;
                        }

                        // Restore email to original email address
                        emailPerson.Email = currentEmail;
                        rockContext.SaveChanges();
                    }
                    catch ( Exception ex )
                    {
                        nbSendTest.Text = ex.Message;
                        nbSendTest.NotificationBoxType = NotificationBoxType.Danger;
                        nbSendTest.Visible = true;
                        return false;
                    }

                    return true;

                } ); // End transaction
            }
        }

        private SystemCommunicationMergeInfo BuildSystemCommunication()
        {
            var systemCommunication = GetSystemCommunication();
            var rockEmailMessage = GetRockEmailMessage();

            var targetPerson = GetTargetPerson();
            var selectedDate = GetSelectedDate();

            var mergeFields = systemCommunication.LavaFields
                .ToDictionary( k => k.Key, v => ( object ) v.Value );

            if ( HasSendDate && selectedDate != null )
            {
                if ( !mergeFields.ContainsKey( MergeFieldKey.SendDateTime ) )
                {
                    mergeFields.Add( MergeFieldKey.SendDateTime, selectedDate.Text );
                }
                else
                {
                    mergeFields[MergeFieldKey.SendDateTime] = selectedDate.Text;
                }
            }

            var mergeFieldOptions = new Rock.Lava.CommonMergeFieldsOptions { GetCurrentPerson = true };
            var commonMergeFields = Rock.Lava.LavaHelper.GetCommonMergeFields( this.RockPage, CurrentPerson, mergeFieldOptions );

            mergeFields.AddOrReplace( MergeFieldKey.Person, targetPerson );

            mergeFields = mergeFields
                .Concat( commonMergeFields.Where( kvp => !mergeFields.ContainsKey( kvp.Key ) ) )
                .ToDictionary( k => k.Key, v => v.Value );

            if ( rockEmailMessage.Message.Contains( PageConstants.LavaDebugCommand ) )
            {
                lavaDebug.Visible = true;
                lavaDebug.Text = mergeFields.lavaDebugInfo();

                // Remove Lava Debug from the message content before it getss sent
                rockEmailMessage.Message = rockEmailMessage.Message.Replace( PageConstants.LavaDebugCommand, string.Empty );
            }
            else
            {
                lavaDebug.Visible = false;
                lavaDebug.Text = string.Empty;
            }

            // If certain fields are blank, then use the Global Attribute values to mimic the EmailTransportComponent.cs behavior.
            var globalAttributes = GlobalAttributesCache.Get();

            // Email - From Name
            if ( systemCommunication.FromName.IsNullOrWhiteSpace() )
            {
                systemCommunication.FromName = globalAttributes.GetValue( "OrganizationName" );
            }
            rockEmailMessage.FromName = ResolveText( systemCommunication.FromName, rockEmailMessage.CurrentPerson, rockEmailMessage.EnabledLavaCommands, mergeFields );

            // Email - From Address
            if ( systemCommunication.From.IsNullOrWhiteSpace() )
            {
                systemCommunication.From = globalAttributes.GetValue( "OrganizationEmail" );
            }
            rockEmailMessage.FromEmail = ResolveText( systemCommunication.From, rockEmailMessage.CurrentPerson, rockEmailMessage.EnabledLavaCommands, mergeFields )
                .Left( 255 );

            // Email - Subject - Max length - RFC 2822 is 998 characters 
            rockEmailMessage.Subject = ResolveText( systemCommunication.Subject, rockEmailMessage.CurrentPerson, rockEmailMessage.EnabledLavaCommands, mergeFields )
                .Left( 998 );

            if ( rockEmailMessage.Subject.IsNotNullOrWhiteSpace() )
            {
                // Remove carriage returns and line feeds
                systemCommunication.Subject = Regex.Replace( rockEmailMessage.Subject, @"(\r?\n?)",
                    string.Empty );
            }

            systemCommunication.LavaFields = mergeFields.ToDictionary( k => k.Key, v => v.Value?.ToString() );

            return new SystemCommunicationMergeInfo
            {
                MergeFields = mergeFields,
                SystemCommunicationRecord = systemCommunication,
                RockEmailMessageRecord = rockEmailMessage,
                TargetPerson = targetPerson,
                SelectedDate = selectedDate
            };
        }

        #endregion Control Events

        #region Methods

        /// <summary>
        /// Builds the UI.
        /// </summary>
        private void BuildUI()
        {
            var previewInfo = SetSystemCommunication();

            nbMessage.Visible = !HasSystemCommunication;

            if ( !HasSystemCommunication )
            {
                nbMessage.NotificationBoxType = Rock.Web.UI.Controls.NotificationBoxType.Danger;
                var communicationSource = previewInfo.ParameterSettingType == SystemCommunicationPreviewInfo.ParameterSettingTypeEnum.BlockSetting ? "was not specified in the block setting or is invalid" : $"was not specified in the block setting or using the [{PageParameterKey.SystemCommunicationId}] url parameter";
                nbMessage.Text = $"A communication template {communicationSource}.";

                EnableControls( false );
            }
            else
            {
                EnableControls();

                // This allow the person to be changed if a TargetPersonId is specified in the query params
                // otherwise it would always override it on the postback
                if ( !Page.IsPostBack )
                {
                    SetTargetPerson();
                }

                BuildDateDropDown();

                var mergeInfo = BuildSystemCommunication();
                var systemCommunication = mergeInfo.SystemCommunicationRecord;
                var emailMessage = mergeInfo.RockEmailMessageRecord;

                var fromName = emailMessage.FromName.IsNotNullOrWhiteSpace() ? emailMessage.FromName : CurrentPerson.FullName;
                var fromEmail = emailMessage.FromEmail.IsNotNullOrWhiteSpace() ? emailMessage.FromEmail : CurrentPerson.Email;

                lTitle.Text = systemCommunication.Title;
                lNavTitle.Text = systemCommunication.Title;
                lFrom.Text = $"<span class='text-semibold'>{emailMessage.FromName}</span> <span class='text-muted'>&lt;{emailMessage.FromEmail}&gt;</span>";
                lSubject.Text = $"<span class='text-semibold'>{emailMessage.Subject}</small>";


                var messageDateTime = GetSendDateValue();
                if ( messageDateTime > DateTime.MinValue )
                {
                    lDate.Text = $"<span class='text-semibold'>{messageDateTime:MMMM d, yyyy}</span>";
                }
                else
                {
                    lDate.Text = $"<span class='text-semibold'>{RockDateTime.Now:MMMM d, yyyy}</span>";
                }

                string source = mergeInfo.RockEmailMessageRecord.Message
                    .ResolveMergeFields( mergeInfo.MergeFields, null, EnabledLavaCommands )
                    .ConvertHtmlStylesToInlineAttributes()
                    .EncodeHtml();

                lContent.Text = PageConstants.EmailContainerHtml.Replace( PageConstants.SystemCommunicationSourceReplacementKey, source );
            }
        }

        /// <summary>
        /// Controls the state.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private void EnableControls( bool enabled = true )
        {
            ddlMessageDate.Enabled = enabled;
            ppTargetPerson.Enabled = enabled;
            btnSendEmail.Enabled = enabled;
            btnDesktop.Disabled = !enabled;
            btnMobile.Disabled = !enabled;
            lbUpdate.Enabled = enabled;
        }

        /// <summary>
        /// Builds the date drop down.
        /// </summary>
        private void BuildDateDropDown()
        {
            var systemCommunication = GetSystemCommunication();

            var dayOfWeeks = GetAttributeValues( AttributeKey.SendDaysOfTheWeek )?
                .Select( dow => ( DayOfWeek ) Enum.Parse( typeof( DayOfWeek ), dow ) );

            var previousWeeks = GetAttributeValue( AttributeKey.PreviousWeeksToShow ).ToIntSafe();
            var futureWeeks = GetAttributeValue( AttributeKey.FutureWeeksToShow ).ToIntSafe();

            HasSendDate = systemCommunication.Body.Contains( $"{{ {MergeFieldKey.SendDateTime} }}" );

            ddlMessageDate.Visible = HasSendDate && dayOfWeeks.Count() > 0;

            if ( ddlMessageDate.Visible )
            {
                ddlMessageDate.Required = true;

                if ( !Page.IsPostBack )
                {
                    var startDate = RockDateTime.Now.AddDays( -( previousWeeks * 7 ) );
                    var endDate = RockDateTime.Now.AddDays( futureWeeks * 7 );
                    int previousMonth = 0;

                    for ( var dt = startDate; dt <= endDate; dt = dt.AddDays( 1 ) )
                    {
                        if ( dayOfWeeks.Contains( dt.DayOfWeek ) )
                        {
                            ddlMessageDate.Items.Add( new ListItem
                            {
                                Text = dt.ToString( "MMMM d, yyyy" ),
                                Value = $"{dt:MMddyyyy}"
                            } );

                            previousMonth = dt.Month;
                        }
                    }

                    ddlMessageDate.SelectedIndex = 0;

                    // Set the date from the query string param
                    var inputDate = DateTime.Now;
                    var publicationDate = PageParameter( PageParameterKey.PublicationDate ).AsDateTime();
                    if ( publicationDate.HasValue )
                    {
                        var publicationDateValue = publicationDate.Value.ToString( "MMddyyyy" );
                        var incomingDateItem = ddlMessageDate.Items.FindByValue( publicationDateValue );
                        if ( incomingDateItem != null )
                        {
                            ddlMessageDate.SelectedValue = incomingDateItem.Value;
                        }

                        inputDate = publicationDate.Value;
                    }


                    // Find the closest date
                    var allDates = new List<DateTime>();

                    foreach ( ListItem dateItem in ddlMessageDate.Items )
                    {
                        DateTime dateItemValue = DateTime.MinValue;

                        if ( DateTime.TryParse( dateItem.Text, out dateItemValue ) )
                        {
                            allDates.Add( dateItemValue );
                        }
                    }

                    if ( allDates != null )
                    {
                        allDates = allDates.OrderBy( d => d ).ToList();

                        var closestDate = inputDate >= allDates.Last()
                            ? allDates.Last()
                            : inputDate <= allDates.First()
                                ? allDates.First()
                                : allDates.First( d => d.ToDateKey() >= inputDate.ToDateKey() );

                        ddlMessageDate.SelectedValue = ddlMessageDate.Items.FindByValue( closestDate.ToString( "MMddyyyy" ) ).Value;
                    }
                    else
                    {
                        ddlMessageDate.SelectedIndex = 0;
                    }

                    ViewState[ViewStateKey.SelectedDate] = ddlMessageDate.SelectedIndex;
                }
            }
            else
            {
                ddlMessageDate.Required = false;
                ViewState[ViewStateKey.SelectedDate] = -1;
            }
        }

        /// <summary>
        /// Sets the system communication.
        /// </summary>
        /// <returns>JobPreviewInfo.</returns>
        private SystemCommunicationPreviewInfo SetSystemCommunication()
        {
            var previewInfo = new SystemCommunicationPreviewInfo();

            var systemCommunicationGuid = GetAttributeValue( AttributeKey.SystemCommunication ).AsGuid();

            if ( !systemCommunicationGuid.IsEmpty() )
            {
                previewInfo.ParameterSettingType = SystemCommunicationPreviewInfo.ParameterSettingTypeEnum.BlockSetting;
                ViewState[ViewStateKey.SystemCommunicationGuid] = systemCommunicationGuid;
            }
            else
            {
                previewInfo.ParameterSettingType = SystemCommunicationPreviewInfo.ParameterSettingTypeEnum.QueryStringParameter;
                var systemCommunicationId = PageParameter( PageParameterKey.SystemCommunicationId ).AsInteger();
                if ( systemCommunicationId > 0 )
                {
                    var systemCommunicationService = new SystemCommunicationService( new RockContext() );
                    var systemCommunication = systemCommunicationService.Get( systemCommunicationId );
                    if ( systemCommunication != null )
                    {
                        systemCommunicationGuid = systemCommunication.Guid;
                        ViewState[ViewStateKey.SystemCommunicationGuid] = systemCommunicationGuid;
                    }
                }
            }
            HasSystemCommunication = ViewState[ViewStateKey.SystemCommunicationGuid].ToStringSafe().Length > 0;
            return previewInfo;
        }

        private SystemCommunication GetSystemCommunication()
        {
            var systemCommunicationGuid = ViewState[ViewStateKey.SystemCommunicationGuid].ToStringSafe().AsGuid();
            if ( systemCommunicationGuid != Guid.Empty )
            {
                var communicationService = new SystemCommunicationService( new RockContext() );
                return communicationService.Get( systemCommunicationGuid );
            }

            return null;
        }

        private RockEmailMessage GetRockEmailMessage()
        {
            var systemCommunicationGuid = ViewState[ViewStateKey.SystemCommunicationGuid].ToStringSafe().AsGuid();
            if ( systemCommunicationGuid != Guid.Empty )
            {
                var rockMessage = new RockEmailMessage( systemCommunicationGuid )
                {
                    AppRoot = ResolveRockUrl( "~/" ),
                    ThemeRoot = ResolveRockUrl( "~~/" )
                };

                return rockMessage;
            }

            return null;
        }

        private Person GetTargetPerson()
        {
            var personId = ViewState[ViewStateKey.TargetPersonId].ToIntSafe();
            if ( personId > 0 )
            {
                var personService = new PersonService( new RockContext() );
                return personService.Get( personId );
            }

            return null;
        }

        private ListItem GetSelectedDate()
        {
            var selectedIndex = ViewState[ViewStateKey.SelectedDate].ToIntSafe();
            if ( selectedIndex > 0 )
            {
                return ddlMessageDate.Items[selectedIndex];
            }

            return null;
        }

        /// <summary>
        /// Sets the target person.
        /// </summary>
        private void SetTargetPerson()
        {
            var targetPersonId = PageParameter( PageParameterKey.TargetPersonId ).ToIntSafe();

            if ( targetPersonId > 0 )
            {
                ViewState[ViewStateKey.TargetPersonId] = targetPersonId;
            }
            else
            {
                var targetPersonValue = ppTargetPerson.SelectedValue.GetValueOrDefault( 0 );
                if ( targetPersonValue > 0 )
                {
                    ViewState[ViewStateKey.TargetPersonId] = targetPersonValue;
                }
                else
                {
                    ViewState[ViewStateKey.TargetPersonId] = CurrentPerson.Id;
                }
            }

            HasTargetPerson = ViewState[ViewStateKey.TargetPersonId].ToIntSafe() > 0;

            if ( HasTargetPerson )
            {
                targetPersonId = ViewState[ViewStateKey.TargetPersonId].ToIntSafe();
                var person = new PersonService( new RockContext() ).Get( targetPersonId );
                ppTargetPerson.SetValue( person );
            }
        }

        /// <summary>
        /// Used to mimic the behavior of the EmailTransportComponent.
        /// </summary>
        private string ResolveText( string content, Person person, string enabledLavaCommands, Dictionary<string, object> mergeFields )
        {
            if ( content.IsNullOrWhiteSpace() )
            {
                return content;
            }

            string value = content.ResolveMergeFields( mergeFields, person, enabledLavaCommands );

            return value;
        }

        /// <summary>
        /// Updates the target person URL parameter.
        /// </summary>
        /// <param name="targetPersonValue">The target person value.</param>
        private void UpdateTargetPersonUrlParam( int targetPersonValue )
        {
            var pageParms = PageParameters();

            if ( pageParms != null )
            {
                if ( pageParms.ContainsKey( PageParameterKey.TargetPersonId ) )
                {
                    pageParms[PageParameterKey.TargetPersonId] = targetPersonValue;
                }
            }

            if ( pageParms != null )
            {
                NavigateToCurrentPage( pageParms.ToDictionary( kv => kv.Key, kv => kv.Value.ToString() ) );
            }
        }

        /// <summary>
        /// Updates the send date URL parameter.
        /// </summary>
        private void UpdateSendDateUrlParam()
        {
            var pageParms = PageParameters();

            if ( pageParms != null )
            {
                var messageDate = GetSendDateValue();
                if ( messageDate > DateTime.MinValue )
                {
                    if ( pageParms.ContainsKey( PageParameterKey.PublicationDate ) )
                    {
                        pageParms[PageParameterKey.PublicationDate] = messageDate.ToString( "MM-dd-yyyy" );
                    }
                    else
                    {
                        pageParms.Add( PageParameterKey.PublicationDate, messageDate.ToString( "MM-dd-yyyy" ) );
                    }
                }

                lDate.Text = $"<span class='text-semibold'>{messageDate:MMMM d, yyyy}</span>";
            }

            if ( pageParms != null )
            {
                NavigateToCurrentPage( pageParms.ToDictionary( kv => kv.Key, kv => kv.Value.ToString() ) );
            }
        }
        private DateTime GetSendDateValue()
        {
            DateTime messageDate;
            if ( !DateTime.TryParseExact( ddlMessageDate.SelectedValue, "MMddyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out messageDate ) )
            {
                messageDate = DateTime.MinValue;
            }
            return messageDate;
        }
        #endregion Methods

        #region Properties

        /// <summary>
        /// Gets the enabled lava commands.
        /// </summary>
        /// <value>
        /// The enabled lava commands.
        /// </value>
        protected string EnabledLavaCommands => GetAttributeValue( AttributeKey.EnabledLavaCommands );

        #endregion

        #region Classes

        /// <summary>
        /// Class SystemCommunicationMergeInfo.
        /// </summary>
        internal class SystemCommunicationMergeInfo
        {
            /// <summary>
            /// Gets or sets the merge fields.
            /// </summary>
            /// <value>The merge fields.</value>
            internal Dictionary<string, object> MergeFields { get; set; }

            /// <summary>
            /// Gets or sets the system communication record.
            /// </summary>
            /// <value>The system communication record.</value>
            internal SystemCommunication SystemCommunicationRecord { get; set; }

            /// <summary>
            /// Gets or sets the rock email message record.
            /// </summary>
            /// <value>The rock email message record.</value>
            internal RockEmailMessage RockEmailMessageRecord { get; set; }

            /// <summary>
            /// Gets or sets the target person.
            /// </summary>
            /// <value>The target person.</value>
            internal Person TargetPerson { get; set; }

            /// <summary>
            /// Gets or sets the selected date.
            /// </summary>
            /// <value>The selected date.</value>
            internal ListItem SelectedDate { get; set; }
        }

        /// <summary>
        /// Class SystemCommunicationPreviewInfo.
        /// </summary>
        internal class SystemCommunicationPreviewInfo
        {
            /// <summary>
            /// Enum ParameterSettingTypeEnum
            /// </summary>
            internal enum ParameterSettingTypeEnum
            {
                BlockSetting,
                QueryStringParameter
            }

            /// <summary>
            /// Gets or sets the type of the parameter setting.
            /// </summary>
            /// <value>The type of the parameter setting.</value>
            internal ParameterSettingTypeEnum ParameterSettingType { get; set; }
        }

        #endregion
    }
}