//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
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
//

/** Service Job guids */
export const ServiceJob = {
    /** The collect hosting metrics job - collect metrics regarding database connections, Etc. */
    CollectHostingMetrics: "36FA38CA-9DB0-40A8-BABD-5411121B4809",
    /** The data migrations 120 add communication get queued index */
    DataMigrations120AddCommunicationGetQueuedIndex: "BF3AADCC-B2A5-4EB9-A365-08C3F052A551",
    /** The data migrations 120 add communication recipient index */
    DataMigrations120AddCommunicationrecipientIndex: "AD7CAEAC-6C84-4B55-9E5A-FEE085C270E4",
    /** The Job to run Post v12 to update interaction indexes. */
    DataMigrations120UpdateInteractionIndexes: "090CB437-F74B-49B0-8B51-BF2A491DD36D",
    /** The Job to run Post v12.2 Data Migrations for adding PersonalDeviceId to Interaction index */
    DataMigrations122InteractionPersonalDeviceId: "6BEDCC6F-620B-4DE0-AE9F-F6DB0E0153E4",
    /** The Job to run Post v12.4 Data Migrations to decrypt the expiration month / year and the name on card fields. */
    DataMigrations124DecryptFinancialPaymentDetails: "6C795E61-9DD4-4BE8-B9EB-E662E43B5E12",
    /** The Job to run Post v12.4 Data Migrations for Update Group Salutation fields on Rock.Model.Group. */
    DataMigrations124UpdateGroupSalutations: "584F899B-B974-4847-9473-15099AADD577",
    /** The Job to run Post v12.5 Data Migrations for Add SystemCommunicationId index to Communication */
    DataMigrations125AddCommunicationSystemCommunicationIdIndex: "DA54E879-44CE-433C-A472-54B57B11CB7B",
    /** The Job to run Post v12.5 Data Migrations for Update Step Program Completion */
    DataMigrations125UpdateStepProgramCompletion: "E7C54AAB-451E-4E89-8083-CF398D37416E",
    /** The Job to run Post v12.7 Data Migrations for Rebuild Group Salutation fields on Rock.Model.Group. */
    DataMigrations127RebuildGroupSalutations: "FD32833A-6FC8-43E6-8D36-0C840DBE99F8",
    /** The Job to run Post v13.0 Data Migrations for Add InteractionComponentId index to Interaction */
    DataMigrations130AddInteractionInteractionComponentIdIndex: "1D7FADEC-2A8A-46FD-898E-58544E7FD9F2",
    /** The Job to run Post v13.3 Data Migrations for Adding InteractionSessionLocationId index to Interaction Session */
    DataMigrations133AddInteractionSessionInteractionSessionLocationIdIndex: "219BF98C-C10C-4B19-86DB-C69D9B8705FC",
    /** The Job to run the Post v13.6 Data Migration to fix the eRA Start Date issue (#5072) */
    DataMigrations136FixIncorrectEraStartDate: "C02ADF2E-A5C3-484F-9C7B-666AB7C5B333",
    /** The Job to run Post v14.0 Data Migrations for Add missing Media Element interactions */
    DataMigrations140AddMissingMediaElementInteractions: "3E6817DA-CEE0-42F8-A30E-FF787719493C",
    /** The Job to run Post v140 to add FK indexes on RegistrationRegistrant.RegistrationTemplateId, GroupMember.GroupTypeId, and ConnectionRequest.ConnectionTypeId. */
    DataMigrations140CreateFkIndexes: "D96BD1F7-6A4A-4DC0-B10D-40031F709573",
    /** The Job to run Post v14.0 Data Migrations to update current sessions */
    DataMigrations140UpdateCurrentSessions: "53A6804F-5895-4E19-907D-916B5CF175AB",
    /** The Job to run Post v14.1 Data Migrations to add some missing indexes */
    DataMigrations141AddMissingIndexes: "B1970CD1-1DDD-46FC-B259-6D151D53374D",
    /** The Job to run Post v14.1 Data Migrations to update current sessions that might have 1900-01-01 set as the DurationLastCalculatedDateTime */
    DataMigrations141RecreateMetricAnalyticsViews: "8AF951F3-742B-433C-B7C0-BDF71B9A78FC",
    /** The Job to run Post v14.1 Data Migrations to update current sessions that might have 1900-01-01 set as the DurationLastCalculatedDateTime */
    DataMigrations141UpdateCurrentSessions1900: "12925E67-1E4F-47E5-BB5E-DD411909F90E",
    /** The Job to run Post v14.1 Data Migrations for Update AttributeValues of type SlidingDateRangeFieldType to RoundTrip format. */
    DataMigrations141UpdateSlidingDateRangeValue: "59D32B1D-5D9A-4B1E-836A-43BBE89BA004",
    /** The Job to run Post v14.1 Data Migrations to update the ValueAs___ columns after migration. */
    DataMigrations141UpdateValueasAttributeValueColumns: "f7786b0a-e80a-4f19-b0c4-d4f85f4affa2",
    /** The Job to run Post v15.0 Data Migrations to add a new mobile rest group and add existing mobile applications into that group. */
    DataMigrations150MobileApplicationUsersRestGroup: "480E996E-6A31-40DB-AE98-BFF85CDED506",
    /** The Job to run Post v14.1 Data Migrations to replace all existing instances of the TransactionEntryBlock with a new instance of the UtilityPaymentEntry block. */
    DataMigrations150ReplaceTransactionEntryBlocksWithUtilityPaymentEntryBlock: "8A013CC5-CB51-48F3-8AF8-767BDECACAFE",
    /** The Job to run Post v15.1 Replace Web Forms Blocks with Obsidian Blocks. */
    DataMigrations150ReplaceWebFormsBlocksWithObsidianBlocks: "EA00D1D4-709A-4102-863D-08471AA2C345",
    /** The Job to run Post v15.1 Data Migrations for System Phone Numbers. */
    DataMigrations150SystemPhoneNumbers: "6DFE731E-F28B-40B3-8383-84212A301214",
    /** The Job to run Post v15.1 Data Migrations to cleanup duplicate mobile interaction entries. */
    DataMigrations151DuplicateMobileInteractionsCleanup: "D3D60B90-48D1-4718-905E-39638B44C665",
    /** The Job to run Post v15.2 Data Migrations for the AttributeValue.IX_ValueAsPersonId index. */
    DataMigrations152IxValueAsPersonId: "5DC19FB3-AB0B-48F3-817D-9023C65C5F8A",
    /** The Job to run Post v15.2 to replace web forms blocks with Obsidian blocks. */
    DataMigrations152ReplaceWebFormsBlocksWithObsidianBlocks: "4232194C-90AE-4B44-93E7-1E5DE984A9E1",
    /** The Job to run Post v15.4 to update the AgeBracket values to reflect the new values after spliting the 0 - 12 bracket. */
    DataMigrations154UpdateAgeBracketValues: "C1234A63-09A6-45C1-96D8-0DE03EC4A7A1",
    /** The post update data migration job to chop the Group Registration block */
    DataMigrations160ChopBlocksGroupRegistration: "72D9EC04-517A-4CA0-B631-9F9A41F1790D",
    /** The Job to run Post v16.0 Move Person Preferences. */
    DataMigrations160MovePersonPreferences: "C8591D15-9D37-49D3-8DF8-1DB72EE42D29",
    /** The Job to run v16.0 - Add New Indices To Interaction and InteractionSession. */
    DataMigrations160PopulateInteractionSessionData: "4C734B0E-8024-4600-99F9-B6CFEE9F8250",
    /** The Job to run v16.0 - Add New Indices To Interaction and InteractionSession. */
    DataMigrations160UpdateInteractionSessionAndInteractionIndices: "30A8FE3D-8C2B-413E-9B94-F4B9212904B1",
    /** The Job to run Post v16.0 Update InteractionSession InteractionChannelId. */
    DataMigrations160UpdateInteractionSessionInteractionChannelId: "3BC5124D-0ED1-4D90-A9ED-D858FA4B5051",
    /** The Job to run Post v16.0 Update InteractionSession SessionStartDateKey. */
    DataMigrations160UpdateInteractionSessionSessionStartDateKey: "EBAD6B4D-D928-41FD-A0DD-445060810504",
    /** The Job to run Post v16.0 Data Migrations to update the media element default urls. */
    DataMigrations160UpdateMediaElementDefaultUrls: "3f2a18ce-882d-4687-a4e4-b2a34af2777d",
    /** The Job to run Post v16.0 Data Migrations to update the note data to match the new formatting. */
    DataMigrations160UpdateNoteData: "3768889a-ba73-4cff-91f9-cc0f92780745",
    /** The Job to run Post v16.0 Update Person PrimaryPersonAliasId. */
    DataMigrations160UpdatePersonPrimaryPersonAliasId: "BC7564DC-594F-4B50-8988-1594849515F1",
    /** The Job to run Post v16.0 Data Migrations to update the newly persisted WorkflowId column on Workflow entity with their correct values. */
    DataMigrations160UpdateWorkflowidColumns: "2222F9D2-4771-4B21-A630-E696DB0C329A",
    /** The Job to run Post v16.1 Data Migrations to swap AccountEntry and Login web forms blocks with obisdian blocks. */
    DataMigrations161ChopAccountentryAndLogin: "A65D26C1-229E-4198-B388-E269C3534BC0",
    /** The post update data migration job to chop the Group Schedule Toolbox V2. */
    DataMigrations161ChopBlockGroupScheduleToolboxV2: "7F989E9F-913C-45E4-9EB1-EC70AC220939",
    /** The post update data migration job to chop the Login and Account Entry blocks. */
    DataMigrations161ChopSecurityBlocks: "A65D26C1-229E-4198-B388-E269C3534BC0",
    /** The post update data migration job to remove obsidian group schedule toolbox back buttons. */
    DataMigrations161RemoveObsidianGroupScheduleToolboxBackButtons: "781F2D3B-E5E4-41D5-9145-1D70DDB3EE04",
    /** The post update data migration job to swap the Group Schedule Toolbox V1. */
    DataMigrations161SwapBlockGroupScheduleToolboxV1: "22DBD648-79C0-40C7-B561-094E4E7637E5",
    /** The Job to run Post v16.1 Data Migrations to swap Financial Batch List web forms block with obsidian block. */
    DataMigrations161SwapFinancialBatchList: "7750ECFD-26E3-49DE-8E90-1B1A6DCCC3FE",
    /** The post update data migration job to chop the Email Preference Entry block. */
    DataMigrations162ChopEmailPreferenceEntry: "AE07C80A-80A4-48FD-908C-56DDB1CAA322",
    /** The Job to run Post v16.6 to add a new index to the CommunicationRecipient table. */
    DataMigrations166AddCommunicationRecipientIndex: "48070B65-FC20-401F-B25F-8F4D13BA5F36",
    /** The Job to run Post v16.6 Data Migrations to an index to the CreatedDateTime column on the Interaction table. */
    DataMigrations166AddInteractionCreatedDateTimeIndex: "2B2E2C6F-0184-4797-9D39-E8FC700D9887",
    /** The Job to run Post v17.0 Data Migrations to chop 6 blocks Block. */
    DataMigrations166ChopObsidianBlocks: "4B8A66B3-1D92-480C-B473-D066B64E72AD",
    /**
     * The Job to run Post v16.6 Data Migrations to update the newly
     * created TargetCount column on AchievementType.
     */
    DataMigrations166UpdateAchievementtypeTargetcountColumn: "ab4d7fa7-8e07-48d3-8225-bdecc63b71f5",
    /** The Job to run Post v16.7 to populate EntityIntents from AdditionalSettingsJson. */
    DataMigrations167PopulateEntityIntentsFromAdditionalSettingsJson: "155C2051-1513-4BB3-83AD-8D37EBBC3F59",
    /** The Job to run Post v17.0 Data Migrations to chop Shortened Link Block. */
    DataMigrations170ChopShortenedLinksBlock: "8899363A-C52B-4D82-88C2-CA199D73E95C",
    /** The post update data migration job to remove the legacy Communication Recipient List Webforms block. */
    DataMigrations170RemoveCommunicationRecipientListBlock: "54CCFFFD-83A8-4BB6-A699-DDE34310BFE6",
    /** The post update data migration job to remove the legacy Communication Recipient List Webforms block. */
    DataMigrations170RemoveDiscBlock: "795AE7B0-8B61-4577-B50A-350907CA0C65",
    /** The post update data migration job to remove legacy preference attributes. */
    DataMigrations170RemoveLegacyPreferences: "46d98280-7611-4588-831d-6924e2be9da6",
    /**
     * The Post Update Data Migration Job to chop the Schedule Detail, Asset Storage Provider Detail, Page Short Link Detail, Streak Type Detail,
     * Following Event Type Detail, Financial Batch Detail
     */
    DataMigrationsChopBlocksGroup1: "54FACAE5-2175-4FE0-AC9F-5CDA957BCFB5",
    /** The Post Update Data Migration Job to swap the Notes Block */
    DataMigrationsSwapNotesBlock: "8390C1AC-88D6-474A-AC05-8FFBD358F75D",
    /** The Job to get NCOA */
    GetNcoa: "D2D6EA6C-F94A-39A0-481B-A23D08B887D6",
    /** Use Rock.SystemGuid.ServiceJob.GIVING_AUTOMATION instead */
    GivingAnalytics: "B6DE0544-8C91-444E-B911-453D4CE71515",
    /** The Rock.Jobs.GivingAutomation job. */
    GivingAutomation: "B6DE0544-8C91-444E-B911-453D4CE71515",
    /** Gets the Job Pulse guid */
    JobPulse: "CB24FF2A-5AD3-4976-883F-DAF4EFC1D7C7",
    /** The Job to Migrate pre-v8.0 History Summary Data */
    MigrateHistorySummaryData: "CF2221CC-1E0A-422B-B0F7-5D81AF1DDB14",
    /** A run once job after a new installation. The purpose of this job is to populate generated datasets after an initial installation using RockInstaller that are too large to include in the installer. */
    PostInstallDataMigrations: "322984F1-A7A0-4D1B-AE6F-D7F043F66EB3",
    /** The Process Elevated Security Job. Rock.Jobs.ProcessElevatedSecurity */
    ProcessElevatedSecurity: "A1AF9D7D-E968-4AF6-B203-6BB4FD625714",
    /** The Rock.Jobs.ProcessReminders job. */
    ProcessReminders: "3F697C80-4C33-4552-9038-D3470445EA40",
    /**
     * The Job to Rebuild a Sequence. This job has been deleted and replaced with
     * Rock.Transactions.StreakTypeRebuildTransaction
     */
    RebuildStreak: "BFBB9524-10E8-42CF-BCD3-0CC7D2B22C3A",
    /** The rock cleanup Job. Rock.Jobs.RockCleanup */
    RockCleanup: "1A8238B1-038A-4295-9FDE-C6D93002A5D7",
    /** The Job to send an email digest with an attendance summary of all child groups to regional group leaders */
    SendGroupAttendanceDigest: "9F9E9C3B-FC58-4939-A272-4FA86D44CE7B",
    /** The job for sending available learning activity notifications. Rock.Jobs.SendLearningActivityNotifications. */
    SendLearningActivityNotifications: "0075859b-8dc3-4e95-9075-89198886fcb4",
    /** The steps automation job - add steps based on people in a dataview */
    StepsAutomation: "97858941-0447-49D6-9E35-B03665FEE965",
    /** The media synchronize job. */
    SyncMedia: "FB27C6DF-F8DB-41F8-83AF-BBE09E77A0A9",
    /** The Rock.Jobs.UpdateAnalyticsSourcePostalCode job. */
    UpdateAnalyticsSourcePostalCode: "29731D97-699D-4D34-A9F4-50C7C33D5C48",
    /** The Update Persisted Attribute Values job. */
    UpdatePersistedAttributeValue: "A7DDA4B0-BA1D-49F1-8749-5E7A9876AE70",
    /** The Rock.Jobs.UpdatePersistedDatasets job. */
    UpdatePersistedDatasets: "B6D3B48A-039A-4A1C-87BE-3FC0152AB5DA",
    /** The Rock.Jobs.UpdatePersonalizationData job. */
    UpdatePersonalizationData: "67CFE1FE-7C64-4328-8576-F1A4BFD0EA8B",
    /** The job for updating learning program completions. Rock.Jobs.UpdateProgramCompletions. */
    UpdateProgramCompletions: "4E805A88-C031-4BA0-BAD6-0A706E647870",
};
