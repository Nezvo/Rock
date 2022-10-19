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
export const enum ServiceJob {
    /** Gets the Job Pulse guid */
    JobPulse = "CB24FF2A-5AD3-4976-883F-DAF4EFC1D7C7",
    /** The Job to run Post v12 to update interaction indexes. */
    DataMigrations120UpdateInteractionIndexes = "090CB437-F74B-49B0-8B51-BF2A491DD36D",
    /** The data migrations 120 add communication recipient index */
    DataMigrations120AddCommunicationrecipientIndex = "AD7CAEAC-6C84-4B55-9E5A-FEE085C270E4",
    /** The data migrations 120 add communication get queued index */
    DataMigrations120AddCommunicationGetQueuedIndex = "BF3AADCC-B2A5-4EB9-A365-08C3F052A551",
    /** The Job to run Post v12.2 Data Migrations for adding PersonalDeviceId to Interaction index */
    DataMigrations122InteractionPersonalDeviceId = "6BEDCC6F-620B-4DE0-AE9F-F6DB0E0153E4",
    /** The Job to run Post v12.4 Data Migrations for Update Group Salutation fields on Rock.Model.Group. */
    DataMigrations124UpdateGroupSalutations = "584F899B-B974-4847-9473-15099AADD577",
    /** The Job to run Post v12.5 Data Migrations for Update Step Program Completion */
    DataMigrations125UpdateStepProgramCompletion = "E7C54AAB-451E-4E89-8083-CF398D37416E",
    /** The Job to run Post v12.5 Data Migrations for Add SystemCommunicationId index to Communication */
    DataMigrations125AddCommunicationSystemCommunicationIdIndex = "DA54E879-44CE-433C-A472-54B57B11CB7B",
    /** The Job to run Post v12.7 Data Migrations for Rebuild Group Salutation fields on Rock.Model.Group. */
    DataMigrations127RebuildGroupSalutations = "FD32833A-6FC8-43E6-8D36-0C840DBE99F8",
    /** The Job to run Post v13.0 Data Migrations for Add InteractionComponentId index to Interaction */
    DataMigrations130AddInteractionInteractionComponentIdIndex = "1D7FADEC-2A8A-46FD-898E-58544E7FD9F2",
    /** The Job to run Post v13.3 Data Migrations for Adding InteractionSessionLocationId index to Interaction Session */
    DataMigrations133AddInteractionSessionInteractionSessionLocationIdIndex = "219BF98C-C10C-4B19-86DB-C69D9B8705FC",
    /** The Job to run the Post v13.6 Data Migration to fix the eRA Start Date issue (#5072) */
    DataMigrations136FixIncorrectEraStartDate = "C02ADF2E-A5C3-484F-9C7B-666AB7C5B333",
    /** The Job to Migrate pre-v8.0 History Summary Data */
    MigrateHistorySummaryData = "CF2221CC-1E0A-422B-B0F7-5D81AF1DDB14",
    /** The Job to run Post v14.0 Data Migrations for Add missing Media Element interactions */
    DataMigrations140AddMissingMediaElementInteractions = "3E6817DA-CEE0-42F8-A30E-FF787719493C",
    /** The Job to run Post v14.0 Data Migrations to update current sessions */
    DataMigrations140UpdateCurrentSessions = "53A6804F-5895-4E19-907D-916B5CF175AB",
    /** The Job to run Post v140 to add FK indexes on RegistrationRegistrant.RegistrationTemplateId, GroupMember.GroupTypeId, and ConnectionRequest.ConnectionTypeId. */
    DataMigrations140CreateFkIndexes = "D96BD1F7-6A4A-4DC0-B10D-40031F709573",
    /** The Job to run Post v12.4 Data Migrations to decrypt the expiration month / year and the name on card fields. */
    DataMigrations124DecryptFinancialPaymentDetails = "6C795E61-9DD4-4BE8-B9EB-E662E43B5E12",
    /** The Job to get NCOA */
    GetNcoa = "D2D6EA6C-F94A-39A0-481B-A23D08B887D6",
    /**
     * The Job to Rebuild a Sequence. This job has been deleted and replaced with
     * Rock.Transactions.StreakTypeRebuildTransaction
     */
    RebuildStreak = "BFBB9524-10E8-42CF-BCD3-0CC7D2B22C3A",
    /** The rock cleanup Job. Rock.Jobs.RockCleanup */
    RockCleanup = "1A8238B1-038A-4295-9FDE-C6D93002A5D7",
    /** The steps automation job - add steps based on people in a dataview */
    StepsAutomation = "97858941-0447-49D6-9E35-B03665FEE965",
    /** The collect hosting metrics job - collect metrics regarding database connections, Etc. */
    CollectHostingMetrics = "36FA38CA-9DB0-40A8-BABD-5411121B4809",
    /** The Job to send an email digest with an attendance summary of all child groups to regional group leaders */
    SendGroupAttendanceDigest = "9F9E9C3B-FC58-4939-A272-4FA86D44CE7B",
    /** A run once job after a new installation. The purpose of this job is to populate generated datasets after an initial installation using RockInstaller that are too large to include in the installer. */
    PostInstallDataMigrations = "322984F1-A7A0-4D1B-AE6F-D7F043F66EB3",
    /** The Rock.Jobs.GivingAutomation job. */
    GivingAutomation = "B6DE0544-8C91-444E-B911-453D4CE71515",
    /** Use Rock.SystemGuid.ServiceJob.GIVING_AUTOMATION instead */
    GivingAnalytics = "B6DE0544-8C91-444E-B911-453D4CE71515",
    /** The media synchronize job. */
    SyncMedia = "FB27C6DF-F8DB-41F8-83AF-BBE09E77A0A9",
    /** The Process Elevated Security Job. Rock.Jobs.ProcessElevatedSecurity */
    ProcessElevatedSecurity = "A1AF9D7D-E968-4AF6-B203-6BB4FD625714",
    /** The Rock.Jobs.UpdatePersonalizationData job. */
    UpdatePersonalizationData = "67CFE1FE-7C64-4328-8576-F1A4BFD0EA8B",
    /** The Rock.Jobs.ProcessReminders job. */
    ProcessReminders = "3F697C80-4C33-4552-9038-D3470445EA40",
}
