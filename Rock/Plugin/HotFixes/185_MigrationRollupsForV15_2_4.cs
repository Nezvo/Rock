﻿// <copyright>
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

namespace Rock.Plugin.HotFixes
{
    /// <summary>
    /// Plug-in migration
    /// </summary>
    /// <seealso cref="Rock.Plugin.Migration" />
    [MigrationNumber( 185, "1.15.1" )]
    public class MigrationRollupsForV15_2_4 : Migration
    {

        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            ResetBlockSettingGroupAttendanceDetailListItemDetailsTemplate();
            CorrectPersonRemindersMergedRecords();
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            // Down migrations are not yet supported in plug-in migrations.
        }

        /// <summary>
        /// JMH: Reset Block Setting: Group Attendance Detail - List Item Details Template
        /// </summary>
        private void ResetBlockSettingGroupAttendanceDetailListItemDetailsTemplate()
        {
            Sql( @"
DECLARE @EntityTypeId_BlockType INT = (SELECT [Id] FROM [EntityType] WHERE [Name] = 'Rock.Model.Block')
DECLARE @BlockTypeId_GroupAttendanceDetail INT = (SELECT [Id] FROM [BlockType] WHERE [Guid] = '308DBA32-F656-418E-A019-9D18235027C1')
DECLARE @AttributeKey_ListItemDetailsTemplate NVARCHAR(1000) = N'ListItemDetailsTemplate'

UPDATE [AttributeValue]
   SET [Value] = '',
       [IsPersistedValueDirty] = 1
 WHERE [AttributeId] IN (
    SELECT [Id]
      FROM [Attribute]
     WHERE [EntityTypeId] = @EntityTypeId_BlockType
           AND [EntityTypeQualifierColumn] = 'BlockTypeId'
           AND [EntityTypeQualifierValue] = @BlockTypeId_GroupAttendanceDetail
           AND [Key] = @AttributeKey_ListItemDetailsTemplate
)
" );
        }

        /// <summary>
        /// SC: Correct Person Reminders for Merged Records
        /// </summary>
        private void CorrectPersonRemindersMergedRecords()
        {
            Sql( @"DECLARE @EntityTypeId_Person INT = (SELECT [Id] FROM [EntityType] WHERE [Guid] = '72657ED8-D16E-492E-AC12-144C5E7567E7');
UPDATE
	[Reminder]
SET
	[EntityId] = PA.[PersonId]
FROM
	[Reminder] R
		INNER JOIN	[PersonAlias] PA
			ON R.[EntityId] = PA.[AliasPersonId]
		LEFT JOIN	[ReminderType] RT
			ON R.[ReminderTypeId] = RT.[Id]
WHERE
	RT.[EntityTypeId] = @EntityTypeId_Person
	AND	PA.[PersonId] <> PA.[AliasPersonId];" );
        }
    }
}
