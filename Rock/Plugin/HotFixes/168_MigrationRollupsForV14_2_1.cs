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
    [MigrationNumber( 168, "1.14.1" )]
    public class MigrationRollupsForV14_2_1 : Migration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            UpdateStatementGeneratorDownloadLinkUp();
            UpdateCheckInAttendanceAnalyticsFirstDatesQueryToImprovePerformance();
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            // Down migrations are not yet supported in plug-in migrations.
        }

        /// <summary>
        /// JPH: Update the Statement Generator download link to the 1.14.2.0 version of the Statement Generator installer.
        /// </summary>
        private void UpdateStatementGeneratorDownloadLinkUp()
        {
            Sql( @"
DECLARE @DownloadUrlAttributeId INT = (SELECT [Id] FROM [Attribute] WHERE [Guid] = 'E0AF9B30-15EA-413B-BAC4-25B286D91FD9');
DECLARE @StatementGeneratorDefinedValueId INT = (SELECT [Id] FROM [DefinedValue] WHERE [Guid] = '54E1EBCC-5A5A-4B26-9CCB-36E7CEB49C3C');

UPDATE [AttributeValue]
SET [Value] = 'https://storage.rockrms.com/externalapplications/sparkdevnetwork/statementgenerator/1.14.2/statementgenerator.msi'
WHERE [AttributeId] = @DownloadUrlAttributeId AND [EntityId] = @StatementGeneratorDefinedValueId;" );
        }

        /// <summary>
        /// JPH: Revert the Statement Generator download link to the 1.14.1.0 version of the Statement Generator installer.
        /// </summary>
        private void UpdateStatementGeneratorDownloadLinkDown()
        {
            Sql( @"
DECLARE @DownloadUrlAttributeId INT = (SELECT [Id] FROM [Attribute] WHERE [Guid] = 'E0AF9B30-15EA-413B-BAC4-25B286D91FD9');
DECLARE @StatementGeneratorDefinedValueId INT = (SELECT [Id] FROM [DefinedValue] WHERE [Guid] = '54E1EBCC-5A5A-4B26-9CCB-36E7CEB49C3C');

UPDATE [AttributeValue]
SET [Value] = 'https://storage.rockrms.com/externalapplications/sparkdevnetwork/statementgenerator/1.14.1/statementgenerator.msi'
WHERE [AttributeId] = @DownloadUrlAttributeId AND [EntityId] = @StatementGeneratorDefinedValueId;" );
        }

        /// <summary>
        /// DL:Migration to modify the spCheckin_AttendanceAnalyticsQuery_AttendeeFirstDates query to improve performance for very large attendance datasets.
        /// </summary>
        private void UpdateCheckInAttendanceAnalyticsFirstDatesQueryToImprovePerformance()
        {
            Sql( $@"
/*
<doc>
	<summary>
        This function return people who attended based on selected filter criteria and the first 5 dates they ever attended the selected group type
	</summary>

	<returns>
		* PersonId
		* TimeAttending
		* SundayDate
	</returns>
	<param name='GroupTypeIds' datatype='varchar(max)'>The Group Type Ids (only attendance for these group types will be included</param>
	<param name='StartDate' datatype='datetime'>Beginning date range filter</param>
	<param name='EndDate' datatype='datetime'>Ending date range filter</param>
	<param name='GroupIds' datatype='varchar(max)'>Optional list of group ids to limit attendance to</param>
	<param name='CampusIds' datatype='varchar(max)'>Optional list of campus ids to limit attendance to</param>
	<param name='IncludeNullCampusIds' datatype='bit'>Flag indicating if attendance not tied to campus should be included</param>
	<remarks>	
	</remarks>
	<code>
        EXEC [dbo].[spCheckin_AttendanceAnalyticsQuery_AttendeeFirstDates] '18,19,20,21,22,23,25', '24,25,26,27,28,29,30,31,32,56,57,58,59,111,112,113,114,115,116,117,118', '2019-09-17 00:00:00', '2019-10-23 00:00:00', null, 0, null
	</code>
</doc>
*/

ALTER PROCEDURE [dbo].[spCheckin_AttendanceAnalyticsQuery_AttendeeFirstDates]
	  @GroupTypeIds varchar(max)
	, @GroupIds varchar(max)
	, @StartDate datetime = NULL
	, @EndDate datetime = NULL
	, @CampusIds varchar(max) = NULL
	, @IncludeNullCampusIds bit = 0
	, @ScheduleIds varchar(max) = NULL
	WITH RECOMPILE

AS

BEGIN

    --  get the SundayDates within the StartDate and EndDate so we can query against AttendanceOccurrence.SundayDate
	DECLARE @startDateSundayDate DATE
	DECLARE @endDateSundayDate DATE

	SELECT @startDateSundayDate = x.StartSundayDate
		,@endDateSundayDate = x.EndSundayDate
	FROM dbo.ufnUtility_GetSundayDateRange(@StartDate, @EndDate) x

	DECLARE @CampusTbl TABLE ( [Id] int )
	INSERT INTO @CampusTbl SELECT [Item] FROM ufnUtility_CsvToTable( ISNULL(@CampusIds,'') )

	DECLARE @ScheduleTbl TABLE ( [Id] int )
	INSERT INTO @ScheduleTbl SELECT [Item] FROM ufnUtility_CsvToTable( ISNULL(@ScheduleIds,'') )

	DECLARE @GroupTbl TABLE ( [Id] int )
	INSERT INTO @GroupTbl SELECT [Item] FROM ufnUtility_CsvToTable( ISNULL(@GroupIds,'') )

	DECLARE @GroupTypeTbl TABLE ( [Id] int )
	INSERT INTO @GroupTypeTbl SELECT [Item] FROM ufnUtility_CsvToTable( ISNULL(@GroupTypeIds,'') )

	-- Get all the attendees
	DECLARE @PersonIdTbl TABLE ( [PersonId] INT NOT NULL )
	INSERT INTO @PersonIdTbl
	SELECT DISTINCT PA.[PersonId]
	FROM [Attendance] A
	INNER JOIN [AttendanceOccurrence] O ON O.[Id] = A.[OccurrenceId]
    INNER JOIN [PersonAlias] PA ON PA.[Id] = A.[PersonAliasId]
	INNER JOIN @GroupTbl [G] ON [G].[Id] = O.[GroupId]
	LEFT OUTER JOIN @CampusTbl [C] ON [C].[id] = [A].[CampusId]
	LEFT OUTER JOIN @ScheduleTbl [S] ON [S].[id] = [O].[ScheduleId]
    WHERE o.[SundayDate] BETWEEN @startDateSundayDate AND @endDateSundayDate
	AND [DidAttend] = 1
	AND ( 
		( @CampusIds IS NULL OR [C].[Id] IS NOT NULL ) OR  
		( @IncludeNullCampusIds = 1 AND A.[CampusId] IS NULL ) 
	)
	AND ( @ScheduleIds IS NULL OR [S].[Id] IS NOT NULL  )

	-- Get the first 5 occasions on which each person attended any of the selected group types regardless of group or campus.
	-- Multiple attendances on the same date are considered as a single occasion.
	SELECT DISTINCT
	    [PersonId]
	    , [TimeAttending]
	    , [StartDate]
	FROM (
	    SELECT 
	        [P].[Id] AS [PersonId]
	        , DENSE_RANK() OVER ( PARTITION BY [P].[Id] ORDER BY [AO].[OccurrenceDate] ) AS [TimeAttending]
	        , [AO].[OccurrenceDate] AS [StartDate]
	    FROM
	        [Attendance] [A]
	        INNER JOIN [AttendanceOccurrence] [AO] ON [AO].[Id] = [A].[OccurrenceId]
	        INNER JOIN [Group] [G] ON [G].[Id] = [AO].[GroupId]
	        INNER JOIN [PersonAlias] [PA] ON [PA].[Id] = [A].[PersonAliasId] 
	        INNER JOIN [Person] [P] ON [P].[Id] = [PA].[PersonId]
	        INNER JOIN @GroupTypeTbl [GT] ON [GT].[id] = [G].[GroupTypeId]
	    WHERE 
	        [P].[Id] IN ( SELECT [PersonId] FROM @PersonIdTbl )
	        AND [DidAttend] = 1
	) [X]
    WHERE [X].[TimeAttending] <= 5

END
" );
        }
    }
}
