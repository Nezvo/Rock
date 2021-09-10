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
//
namespace Rock.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    using Rock.Model;

    /// <summary>
    ///
    /// </summary>
    public partial class GivingJourneyStages : Rock.Migrations.RockMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            JobUp();

            AlterContributionTabBlocksUp();

            AddGivingJourneyPersonAttributes();

            CatchupPagesBlocks_Up();

            PagesBlocks_Up();
        }

        /// <summary>
        /// Pages/Blocks migration for Giving Automation related stuff
        /// </summary>
        private void PagesBlocks_Up()
        {

            // Add/Update BlockType Giving Automation Alerts
            RockMigrationHelper.UpdateBlockTypeByGuid( "Giving Automation Alerts", "Lists of current alerts based on current filters.", "~/Blocks/Finance/GivingAutomationAlerts.ascx", "Finance", "0A813EC3-EC36-499B-9EBD-C3388DC7F49D" );

            // Add/Update BlockType Giving Automation Configuration
            RockMigrationHelper.UpdateBlockTypeByGuid( "Giving Alerts Configuration", " Block used to view and create new alert types for the giving automation system.", "~/Blocks/Finance/GivingAutomationConfiguration.ascx", "Finance", "A91ACA78-68FD-41FC-B652-17A37789EA32" );

            // The Giving Alerts page was added in the GivingAnalyticsUpdates2 migration, but was hidden. 
            // Now, we are ready to have show when allowed
            Sql( $"UPDATE [Page] SET [DisplayInNavWhen] = {( int ) DisplayInNavWhen.WhenAllowed} WHERE [Guid] = '{SystemGuid.Page.GIVING_ALERTS}';" );

            // Add Page Giving Automation Configuration to Site:Rock RMS
            RockMigrationHelper.AddPage( true, "57650485-7727-4392-9C42-36DE50FBEEEA", "D65F783D-87A9-4CC9-8110-E83466A0EADB", "Giving Automation Configuration", "", "490F8A53-85C5-42D1-B305-A531F4924DC6", "" );

            // Add Block Giving Automation Configuration to Page: Giving Automation Configuration, Site: Rock RMS
            RockMigrationHelper.AddBlock( true, "490F8A53-85C5-42D1-B305-A531F4924DC6".AsGuid(), null, "C2D29296-6A87-47A9-A753-EE4E9159C4C4".AsGuid(), "A91ACA78-68FD-41FC-B652-17A37789EA32".AsGuid(), "Giving Automation Configuration", "Main", @"", @"", 0, "1D8DFF62-A3AA-4EA6-A4C5-416853C32D65" );

            // Attribute for BlockType: Giving Overview:Inactive Giver Cutoff (Days)
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "896D807D-2110-4007-AFD1-4D953B83375B", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Inactive Giver Cutoff (Days)", "InactiveGiverCutoff", "Inactive Giver Cutoff (Days)", @"The number of days after which a person is considered an inactive giver.", 0, @"365", "5796A617-552F-4CCE-B40B-9A7162B6FE6D" );

            // Attribute for BlockType: Giving Automation Alerts:Transaction Detail Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "0A813EC3-EC36-499B-9EBD-C3388DC7F49D", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Transaction Detail Page", "TransactionPage", "Detail Page", @"The transaction detail page", 0, @"B67E38CB-2EF1-43EA-863A-37DAA1C7340F", "E264C1BD-4B7C-449C-A884-D738061744BA" );

            // Attribute for BlockType: Giving Automation Alerts:Alert Config Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "0A813EC3-EC36-499B-9EBD-C3388DC7F49D", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Alert Config Page", "ConfigPage", "Config Page", @"The page to configure what criteria should be used to generate alerts.", 1, @"", "477A3801-CFB7-4BEA-A5C1-ED9C2B2E1E9D" );

            // Attribute for BlockType: Giving Overview:Alert List Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "896D807D-2110-4007-AFD1-4D953B83375B", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Alert List Page", "AlertListPage", "Alert List Page", @"The page to see a list of alerts for the person.", 1, @"", "3B85794D-E382-4F65-B931-AE44A789EFF6" );

            // Add Block Attribute Value
            //   Block: Giving Automation Alerts
            //   BlockType: Giving Automation Alerts
            //   Block Location: Page=Giving Alerts, Site=Rock RMS
            //   Attribute: Transaction Detail Page
            /*   Attribute Value: b67e38cb-2ef1-43ea-863a-37daa1c7340f */
            RockMigrationHelper.AddBlockAttributeValue( "DB2CE9D5-B6BE-42C1-ACC0-3EBE03CD6208", "E264C1BD-4B7C-449C-A884-D738061744BA", @"b67e38cb-2ef1-43ea-863a-37daa1c7340f" );

            // Add Block Attribute Value
            //   Block: Giving Automation Alerts
            //   BlockType: Giving Automation Alerts
            //   Block Location: Page=Giving Alerts, Site=Rock RMS
            //   Attribute: Alert Config Page
            /*   Attribute Value: 490f8a53-85c5-42d1-b305-a531f4924dc6 */
            RockMigrationHelper.AddBlockAttributeValue( "DB2CE9D5-B6BE-42C1-ACC0-3EBE03CD6208", "477A3801-CFB7-4BEA-A5C1-ED9C2B2E1E9D", @"490f8a53-85c5-42d1-b305-a531f4924dc6" );

            // Add Block Attribute Value
            //   Block: Giving Overview
            //   BlockType: Giving Overview
            //   Block Location: Page=Contributions, Site=Rock RMS
            //   Attribute: Inactive Giver Cutoff (Days)
            /*   Attribute Value: 365 */
            RockMigrationHelper.AddBlockAttributeValue( "8A8806DB-78F8-42C5-9D09-3723A868D976", "5796A617-552F-4CCE-B40B-9A7162B6FE6D", @"365" );

            // Add Block Attribute Value
            //   Block: Giving Overview
            //   BlockType: Giving Overview
            //   Block Location: Page=Contributions, Site=Rock RMS
            //   Attribute: Alert List Page
            /*   Attribute Value: 490f8a53-85c5-42d1-b305-a531f4924dc6 */
            RockMigrationHelper.AddBlockAttributeValue( "8A8806DB-78F8-42C5-9D09-3723A868D976", "3B85794D-E382-4F65-B931-AE44A789EFF6", @"490f8a53-85c5-42d1-b305-a531f4924dc6" );
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            AlterContributionTabBlocksDown();
            JobDown();
        }

        /// <summary>
        /// Some unrelated Pages/Blocks migrations that hadn't been done yet
        /// </summary>
        private void CatchupPagesBlocks_Up()
        {
            // Attribute for BlockType: Contribution Statement List Lava:Use Person Context
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "22BF5B51-6511-4D31-8A48-4978A454C386", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Use Person Context", "UsePersonContext", "Use Person Context", @"Determines if the person context should be used instead of the CurrentPerson.", 5, @"False", "556EF546-1DDC-4776-8398-1F81F9870FDE" );

            // Attribute for BlockType: Scheduled Transaction List:Person Token Expire Minutes
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "694FF260-8C6F-4A59-93C9-CF3793FE30E6", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Person Token Expire Minutes", "PersonTokenExpireMinutes", "Person Token Expire Minutes", @"When adding a new scheduled transaction from a person detail page, the number of minutes the person token for the transaction is valid after it is issued.", 3, @"60", "087B2B3B-0DD6-489F-8428-6FD6D23D30CE" );

            // Attribute for BlockType: Scheduled Transaction List:Person Token Usage Limit
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "694FF260-8C6F-4A59-93C9-CF3793FE30E6", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Person Token Usage Limit", "PersonTokenUsageLimit", "Person Token Usage Limit", @"When adding a new scheduled transaction from a person detail page, the maximum number of times the person token for the transaction can be used.", 4, @"1", "43008627-ADB7-455B-8DAD-22B8E473A947" );

            // Attribute for BlockType: Contribution Statement List Lava:Max Years To Display
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "22BF5B51-6511-4D31-8A48-4978A454C386", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Max Years To Display", "MaxYearsToDisplay", "Max Years To Display", @"The maximum number of years to display (including the current year).", 1, @"3", "95593340-4780-4F82-9B32-4C65B0E6B65C" );

            // Attribute for BlockType: Scheduled Transaction List:View Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "694FF260-8C6F-4A59-93C9-CF3793FE30E6", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "View Page", "ViewPage", "View Page", @"", 0, @"", "A4F00EB2-FFCD-4911-AB98-113BEE43AC9A" );

            // Attribute for BlockType: Scheduled Transaction List:Add Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "694FF260-8C6F-4A59-93C9-CF3793FE30E6", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Add Page", "AddPage", "Add Page", @"", 0, @"", "F061BDB2-B66A-4BC3-8930-51B40A53CEB7" );

            // Attribute for BlockType: Pledge List:Detail Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "7011E792-A75F-4F22-B17E-D3A58C0EDB6D", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Detail Page", "DetailPage", "Detail Page", @"", 0, @"", "8E77B224-F502-44F8-8C5F-F7C007EF58DB" );

            // Attribute for BlockType: Contribution Statement List Lava:Detail Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "22BF5B51-6511-4D31-8A48-4978A454C386", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Detail Page", "DetailPage", "Detail Page", @"The statement detail page.", 2, @"", "D4C47D9E-ECD9-4D5A-93EA-46BF9C687361" );

            // Attribute for BlockType: Scheduled Transaction List:Entity Type
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "694FF260-8C6F-4A59-93C9-CF3793FE30E6", "3549BAB6-FE1B-4333-AFC4-C5ACA01BB8EB", "Entity Type", "ContextEntityType", "Entity Type", @"The type of entity that will provide context for this block", 0, @"", "6B73846B-448D-4DD6-A494-4183248DD2A5" );

            // Attribute for BlockType: Pledge List:Entity Type
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "7011E792-A75F-4F22-B17E-D3A58C0EDB6D", "3549BAB6-FE1B-4333-AFC4-C5ACA01BB8EB", "Entity Type", "ContextEntityType", "Entity Type", @"The type of entity that will provide context for this block", 0, @"", "A9425EE2-3727-4A91-BA63-1499B0480158" );

            // Attribute for BlockType: Contribution Statement List Lava:Entity Type
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "22BF5B51-6511-4D31-8A48-4978A454C386", "3549BAB6-FE1B-4333-AFC4-C5ACA01BB8EB", "Entity Type", "ContextEntityType", "Entity Type", @"The type of entity that will provide context for this block", 0, @"", "C82E612D-C2E6-45EB-B027-1BCF8177E18A" );

            // Attribute for BlockType: Contribution Statement List Lava:Accounts
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "22BF5B51-6511-4D31-8A48-4978A454C386", "17033CDD-EF97-4413-A483-7B85A787A87F", "Accounts", "Accounts", "Accounts", @"A selection of accounts to use for checking if transactions for the current user exist. If no accounts are provided then all tax-deductible accounts will be considered.", 0, @"", "ED45DB51-72D0-47C1-A223-713563763EB6" );

            // Attribute for BlockType: Contribution Statement List Lava:Lava Template
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "22BF5B51-6511-4D31-8A48-4978A454C386", "1D0D3794-C210-48A8-8C68-3FBEC08A6BA5", "Lava Template", "LavaTemplate", "Lava Template", @"The Lava template to use for the contribution statement.", 3, @"{% assign currentYear = 'Now' | Date:'yyyy' %}

<h4>Available Contribution Statements</h4>

<div class=""margin-b-md"">
{% for statementyear in StatementYears %}
    {% if currentYear == statementyear.Year %}
        <a href=""{{ DetailPage }}?StatementYear={{ statementyear.Year }}"" class=""btn btn-primary"">{{ statementyear.Year }} <small>YTD</small></a>
    {% else %}
        <a href=""{{ DetailPage }}?StatementYear={{ statementyear.Year }}"" class=""btn btn-primary"">{{ statementyear.Year }}</a>
    {% endif %}
{% endfor %}
</div>", "C1F27C66-3C58-4956-B9E8-9875EA3F22C9" );
        }

        private void AddGivingJourneyPersonAttributes()
        {
            var givingOverviewCategory = new List<string>() { SystemGuid.Category.PERSON_ATTRIBUTES_GIVING_OVERVIEW };

            // Rename "Giving Analytic" person category to "Giving Overview"
            RockMigrationHelper.UpdatePersonAttributeCategory( "Giving Overview", "fas fa-hand-holding-usd", "Attributes that describe the most recent classification of this person's giving habits", SystemGuid.Category.PERSON_ATTRIBUTES_GIVING_OVERVIEW );

            RockMigrationHelper.AddOrUpdatePersonAttributeByGuid(
                SystemGuid.FieldType.SINGLE_SELECT,
                givingOverviewCategory,
                "Current Journey Giving Stage",
                "",
                "CurrentJourneyGivingStage",
                "",
                "",
                2010,
                "",
                SystemGuid.Attribute.PERSON_GIVING_CURRENT_GIVING_JOURNEY_STAGE );

            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_CURRENT_GIVING_JOURNEY_STAGE, "fieldtype", "ddl", "69BF55DD-2331-4112-9594-95C38F5A713B" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_CURRENT_GIVING_JOURNEY_STAGE, "repeatColumns", "", "C30349DC-3AF9-4C6A-A815-67B1BE2C9D91" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_CURRENT_GIVING_JOURNEY_STAGE, "values", "0^Non-Giver, 1^New Giver, 2^Occasional Giver, 3^Consistent Giver, 4^Lapsed Giver, 5^Former Giver", "1A9213FC-B567-4793-AF57-89F4C443FF02" );

            RockMigrationHelper.AddOrUpdatePersonAttributeByGuid(
                SystemGuid.FieldType.SINGLE_SELECT,
                givingOverviewCategory,
                "Previous Journey Giving Stage",
                "",
                "PreviousJourneyGivingStage",
                "",
                "",
                2011,
                "",
                SystemGuid.Attribute.PERSON_GIVING_PREVIOUS_GIVING_JOURNEY_STAGE );

            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_PREVIOUS_GIVING_JOURNEY_STAGE, "fieldtype", "ddl", "831BF3D6-3873-4C03-852F-0FC58AD883F6" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_PREVIOUS_GIVING_JOURNEY_STAGE, "repeatColumns", "", "0C9C5A69-E8F8-447F-9A40-CB9FB5D2C6E4" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_PREVIOUS_GIVING_JOURNEY_STAGE, "values", "0^Non-Giver, 1^New Giver, 2^Occasional Giver, 3^Consistent Giver, 4^Lapsed Giver, 5^Former Giver", "4B61627F-3B3A-4150-9F79-01CB023439FC" );

            RockMigrationHelper.AddOrUpdatePersonAttributeByGuid(
                SystemGuid.FieldType.DATE,
                givingOverviewCategory,
                "Journey Giving Stage Change Date",
                "",
                "JourneyGivingStageChangeDate",
                "",
                "",
                2012,
                "",
                SystemGuid.Attribute.PERSON_GIVING_GIVING_JOURNEY_STAGE_CHANGE_DATE );

            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_GIVING_JOURNEY_STAGE_CHANGE_DATE, "datePickerControlType", "Date Picker", "7C3E6647-E3BD-4B31-9170-3E2C77B042CD" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_GIVING_JOURNEY_STAGE_CHANGE_DATE, "displayCurrentOption", "False", "CFD9E6C2-568B-41E8-98BD-E6C5E7FC3FAE" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_GIVING_JOURNEY_STAGE_CHANGE_DATE, "displayDiff", "False", "68F54381-86EB-4779-BF1C-4EE70A26284E" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_GIVING_JOURNEY_STAGE_CHANGE_DATE, "format", "", "0DDC2021-CC42-4994-8AC7-0A861773A231" );
            RockMigrationHelper.AddAttributeQualifier( SystemGuid.Attribute.PERSON_GIVING_GIVING_JOURNEY_STAGE_CHANGE_DATE, "futureYearCount", "", "5B0BDD4C-0261-49C7-A61B-4FB089BB1F48" );
        }

        /// <summary>
        /// Job up.
        /// </summary>
        private void JobUp()
        {
            Sql( $@"
IF NOT EXISTS (
        SELECT 1
        FROM ServiceJob
        WHERE [Guid] = '{Rock.SystemGuid.ServiceJob.GIVING_AUTOMATION}'
        )
BEGIN
    INSERT INTO ServiceJob (
        IsSystem,
        IsActive,
        Name,
        Description,
        Class,
        Guid,
        CreatedDateTime,
        NotificationStatus,
        CronExpression,
        HistoryCount
    ) VALUES (
        1, -- IsSystem
        1, -- IsActive
        'Giving Automation', -- Name
        'Job that updates giving classifications and journey stages, and send any giving alerts.', -- Description
        'Rock.Jobs.GivingAutomation', -- Class
        '{Rock.SystemGuid.ServiceJob.GIVING_AUTOMATION}', -- Guid
        GETDATE(), -- Created
        1, -- All notifications
        '0 0 22 * * ?', -- Cron: 10pm everyday
        500
    )
END
" );
            // Delete any Rock.Jobs.GivingAnalytics (renamed to Rock.Jobs.GivingAutomation) jobs that might have been manually added. 
            Sql( "DELETE FROM [ServiceJob] WHERE [Class] = 'Rock.Jobs.GivingAnalytics'" );
        }

        /// <summary>
        /// Job down.
        /// </summary>
        private void JobDown()
        {
            Sql( $"DELETE FROM ServiceJob WHERE Guid = '{Rock.SystemGuid.ServiceJob.GIVING_AUTOMATION}';" );
        }

        /// <summary>
        /// Alters the contribution tab blocks up.
        /// </summary>
        private void AlterContributionTabBlocksUp()
        {
            RockMigrationHelper.DeleteAttribute( "A6B71434-FD9B-45EC-AA50-07AE5D6BA384" );
            RockMigrationHelper.DeleteAttribute( "ADC80D72-976B-4DFD-B50C-5B2BAC3FFD17" );
            RockMigrationHelper.DeleteAttribute( "375F7220-04C6-4E41-B99A-A2CE494FD74A" );
            RockMigrationHelper.DeleteAttribute( "47B99CD1-FB63-44D7-8586-45BDCDF51137" );
            RockMigrationHelper.DeleteAttribute( "9BCE3FD8-9014-4120-9DCC-06C4936284BA" );
            RockMigrationHelper.DeleteBlock( "B33DF8C4-29B2-4DC5-B182-61FC255B01C0" );

            RockMigrationHelper.DeleteAttribute( "A6B71434-FD9B-45EC-AA50-07AE5D6BA384" );
            RockMigrationHelper.DeleteAttribute( "ADC80D72-976B-4DFD-B50C-5B2BAC3FFD17" );
            RockMigrationHelper.DeleteAttribute( "375F7220-04C6-4E41-B99A-A2CE494FD74A" );
            RockMigrationHelper.DeleteAttribute( "47B99CD1-FB63-44D7-8586-45BDCDF51137" );
            RockMigrationHelper.DeleteAttribute( "9BCE3FD8-9014-4120-9DCC-06C4936284BA" );
            RockMigrationHelper.DeleteBlock( "B33DF8C4-29B2-4DC5-B182-61FC255B01C0" );

            RockMigrationHelper.DeleteAttribute( "3E26B7DF-7A7F-4829-987F-47304C0F845E" );
            RockMigrationHelper.DeleteAttribute( "E9245CFD-4B11-4CE2-A120-BB3AC47C0974" );
            RockMigrationHelper.DeleteBlock( "212EB093-026A-4177-ACE4-25EA9E1DDD41" );

            RockMigrationHelper.DeleteAttribute( "A20E6DB1-B830-4D41-9003-43A184E4C910" );
            RockMigrationHelper.DeleteAttribute( "55FDABC3-22AE-4EE4-9883-8234E3298B99" );
            RockMigrationHelper.DeleteAttribute( "8158A336-8129-4E82-8B61-8C0E883CB91A" );
            RockMigrationHelper.DeleteAttribute( "9227E7D4-5725-49BD-A0B1-43B769E0A529" );
            RockMigrationHelper.DeleteAttribute( "5C3A012C-19A2-4EC7-8440-7534FE175591" );
            RockMigrationHelper.DeleteAttribute( "7825BDD3-E130-4D63-B0A6-79DB1F97EFD6" );
            RockMigrationHelper.DeleteAttribute( "7B554631-3CD5-40C4-8E67-ECED56D4D7C1" );
            RockMigrationHelper.DeleteAttribute( "AC1EF7F3-7B06-4978-84DD-B38025FC2E7B" );
            RockMigrationHelper.DeleteAttribute( "346384B5-1ECE-4949-BFF4-712E1FAA4335" );
            RockMigrationHelper.DeleteAttribute( "5B439A86-D2AD-4223-8D1E-A50FF883D7C2B" );
            RockMigrationHelper.DeleteAttribute( "F37EB885-416A-4B70-B48E-8A25557C7B12" );
            RockMigrationHelper.DeleteAttribute( "F9A168F1-3E59-4C5F-8019-7B17D00B94C9" );
            RockMigrationHelper.DeleteBlock( "96599B45-E080-44AE-8CB7-CCCCA4873398" );

            RockMigrationHelper.DeleteAttribute( "0AAFF537-7EC6-4AA9-A987-68DA1FF8511D" );
            RockMigrationHelper.DeleteAttribute( "831403EB-262E-4BC5-8B5E-F16153493BF5" );
            RockMigrationHelper.DeleteBlock( "013ACB2A-48AD-4325-9566-6A6B821C8C21" );

            RockMigrationHelper.DeleteBlock( "EF8BB598-E991-421F-96A1-3019B3D855A6" );

            RockMigrationHelper.DeleteBlock( "7C698D61-81C9-4942-BFE3-9839130C1A3E" );

            // Add/Update BlockType Giving Configuration        
            RockMigrationHelper.UpdateBlockType( "Giving Configuration", "Block used to view the giving.", "~/Blocks/Crm/PersonDetail/GivingConfiguration.ascx", "CRM > Person Detail", "486E470A-DBD8-48D6-9A97-5B1B490A401E" );

            // Add/Update BlockType Giving Overview      
            RockMigrationHelper.UpdateBlockType( "Giving Overview", "Block used to view the giving.", "~/Blocks/Crm/PersonDetail/GivingOverview.ascx", "CRM > Person Detail", "896D807D-2110-4007-AFD1-4D953B83375B" );

            // Add Block Giving Configuration to Page: Contributions, Site: Rock RMS   
            RockMigrationHelper.AddBlock( true, "53CF4CBE-85F9-4A50-87D7-0D72A3FB2892".AsGuid(), null, "C2D29296-6A87-47A9-A753-EE4E9159C4C4".AsGuid(), "486E470A-DBD8-48D6-9A97-5B1B490A401E".AsGuid(), "Giving Configuration", "SectionA2", @"", @"", 0, "21B28504-6ED3-44E2-BB85-3401F8B1B96A" );

            // Add Block Giving Overview to Page: Contributions, Site: Rock RMS      
            RockMigrationHelper.AddBlock( true, "53CF4CBE-85F9-4A50-87D7-0D72A3FB2892".AsGuid(), null, "C2D29296-6A87-47A9-A753-EE4E9159C4C4".AsGuid(), "896D807D-2110-4007-AFD1-4D953B83375B".AsGuid(), "Giving Overview", "SectionA1", @"", @"", 0, "8A8806DB-78F8-42C5-9D09-3723A868D976" );

            // update block order for pages with new blocks if the page,zone has multiple blocks
            // Update Order for Page: Contributions,  Zone: SectionA1,  Block: Giving Overview    
            Sql( @"UPDATE [Block] SET [Order] = 1 WHERE [Guid] = '8A8806DB-78F8-42C5-9D09-3723A868D976'" );

            // Update Order for Page: Contributions,  Zone: SectionA1,  Block: Transaction Yearly Summary   
            Sql( @"UPDATE [Block] SET [Order] = 0 WHERE [Guid] = 'EF8BB598-E991-421F-96A1-3019B3D855A6'" );

            // Update Order for Page: Contributions,  Zone: SectionA2,  Block: Contribution Statement List Lava  
            Sql( @"UPDATE [Block] SET [Order] = 1 WHERE [Guid] = '96599B45-E080-44AE-8CB7-CCCCA4873398'" );

            // Update Order for Page: Contributions,  Zone: SectionA2,  Block: Giving Configuration         
            Sql( @"UPDATE [Block] SET [Order] = 2 WHERE [Guid] = '21B28504-6ED3-44E2-BB85-3401F8B1B96A'" );

            // Update Order for Page: Contributions,  Zone: SectionA2,  Block: Person Transaction Links    
            Sql( @"UPDATE [Block] SET [Order] = 0 WHERE [Guid] = '013ACB2A-48AD-4325-9566-6A6B821C8C21'" );

            // Update Order for Page: Contributions,  Zone: SectionC1,  Block: Bank Account List        
            Sql( @"UPDATE [Block] SET [Order] = 3 WHERE [Guid] = '7C698D61-81C9-4942-BFE3-9839130C1A3E'" );

            // Update Order for Page: Contributions,  Zone: SectionC1,  Block: Finance - Giving Profile List              
            Sql( @"UPDATE [Block] SET [Order] = 1 WHERE [Guid] = 'B33DF8C4-29B2-4DC5-B182-61FC255B01C0'" );

            // Update Order for Page: Contributions,  Zone: SectionC1,  Block: Pledge List              
            Sql( @"UPDATE [Block] SET [Order] = 0 WHERE [Guid] = '212EB093-026A-4177-ACE4-25EA9E1DDD41'" );

            // Update Order for Page: Contributions,  Zone: SectionC1,  Block: Saved Account List              
            Sql( @"UPDATE [Block] SET [Order] = 4 WHERE [Guid] = '6B21B99D-F048-4DEA-B994-A16972EA87FE'" );

            // Update Order for Page: Contributions,  Zone: SectionC1,  Block: Transaction List              
            Sql( @"UPDATE [Block] SET [Order] = 2 WHERE [Guid] = '9382B285-3EF6-47F7-94BB-A47C498196A3'" );

            // Attribute for BlockType: Giving Configuration:Person Token Expire Minutes  
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Person Token Expire Minutes", "PersonTokenExpireMinutes", "Person Token Expire Minutes", @"The number of minutes the person token for the transaction is valid after it is issued.", 1, @"60", "F94B9ADD-4684-4196-8F51-B77352E327B1" );

            // Attribute for BlockType: Giving Configuration:Person Token Usage Limit   
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Person Token Usage Limit", "PersonTokenUsageLimit", "Person Token Usage Limit", @"The maximum number of times the person token for the transaction can be used.", 2, @"1", "07C2DDAB-9DD8-4E12-B903-8B2021F7BA4D" );

            // Attribute for BlockType: Giving Configuration:Max Years To Display  
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Max Years To Display", "MaxYearsToDisplay", "Max Years To Display", @"The maximum number of years to display (including the current year).", 5, @"3", "61937426-9DB3-4B2F-9448-F6F7E6B0539F" );

            // Attribute for BlockType: Giving Configuration:Add Transaction Page   
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Add Transaction Page", "AddTransactionPage", "Add Transaction Page", @"", 0, @"B1CA86DC-9890-4D26-8EBD-488044E1B3DD", "FAC63421-C934-4563-AAEE-E0EE83514B67" );

            // Attribute for BlockType: Giving Configuration:Contribution Statement Detail Page  
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Contribution Statement Detail Page", "ContributionStatementDetailPage", "Detail Page", @"The contribution statement detail page.", 6, @"", "0023B662-B17F-407A-8E50-DA1B5090CD7B" );

            // Attribute for BlockType: Giving Configuration:Pledge Detail Page   
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Pledge Detail Page", "PledgeDetailPage", "Pledge Detail Page", @"", 4, @"EF7AA296-CA69-49BC-A28B-901A8AAA9466", "B0F0F89E-400B-4BD9-A6CB-B1DE550CDBC7" );

            // Attribute for BlockType: Giving Configuration:Accounts       
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "486E470A-DBD8-48D6-9A97-5B1B490A401E", "17033CDD-EF97-4413-A483-7B85A787A87F", "Accounts", "Accounts", "Accounts", @"A selection of accounts to use for checking if transactions for the current user exist.", 3, @"", "B7D51A75-A356-460C-BF6D-CA1AA0F3BF84" );

            // Attribute for BlockType: Giving Overview:Inactive Giver Cutoff (Days)  
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "896D807D-2110-4007-AFD1-4D953B83375B", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Inactive Giver Cutoff (Days)", "InactiveGiverCutoff", "Inactive Giver Cutoff (Days)", @"The number of days after which a person is considered an inactive giver.", 0, @"365", "5796A617-552F-4CCE-B40B-9A7162B6FE6D" );
        }

        /// <summary>
        /// Alters the contribution tab blocks down.
        /// </summary>
        private void AlterContributionTabBlocksDown()
        {
            // Inactive Giver Cutoff (Days) Attribute for BlockType: Giving Overview              
            RockMigrationHelper.DeleteAttribute( "5796A617-552F-4CCE-B40B-9A7162B6FE6D" );
            // Pledge Detail Page Attribute for BlockType: Giving Configuration   
            RockMigrationHelper.DeleteAttribute( "B0F0F89E-400B-4BD9-A6CB-B1DE550CDBC7" );
            // Contribution Statement Detail Page Attribute for BlockType: Giving Configuration     
            RockMigrationHelper.DeleteAttribute( "0023B662-B17F-407A-8E50-DA1B5090CD7B" );
            // Max Years To Display Attribute for BlockType: Giving Configuration    
            RockMigrationHelper.DeleteAttribute( "61937426-9DB3-4B2F-9448-F6F7E6B0539F" );
            // Accounts Attribute for BlockType: Giving Configuration      
            RockMigrationHelper.DeleteAttribute( "B7D51A75-A356-460C-BF6D-CA1AA0F3BF84" );
            // Person Token Usage Limit Attribute for BlockType: Giving Configuration        
            RockMigrationHelper.DeleteAttribute( "07C2DDAB-9DD8-4E12-B903-8B2021F7BA4D" );
            // Person Token Expire Minutes Attribute for BlockType: Giving Configuration   
            RockMigrationHelper.DeleteAttribute( "F94B9ADD-4684-4196-8F51-B77352E327B1" );
            // Add Transaction Page Attribute for BlockType: Giving Configuration    
            RockMigrationHelper.DeleteAttribute( "FAC63421-C934-4563-AAEE-E0EE83514B67" );
            // Remove Block: Giving Overview, from Page: Contributions, Site: Rock RMS    
            RockMigrationHelper.DeleteBlock( "8A8806DB-78F8-42C5-9D09-3723A868D976" );
            // Remove Block: Giving Configuration, from Page: Contributions, Site: Rock RMS    
            RockMigrationHelper.DeleteBlock( "21B28504-6ED3-44E2-BB85-3401F8B1B96A" );
            // Delete BlockType Giving Overview            
            RockMigrationHelper.DeleteBlockType( "896D807D-2110-4007-AFD1-4D953B83375B" ); // Giving Overview  
            // Delete BlockType Giving Configuration       
            RockMigrationHelper.DeleteBlockType( "486E470A-DBD8-48D6-9A97-5B1B490A401E" ); // Giving Configuration  
        }
    }
}
