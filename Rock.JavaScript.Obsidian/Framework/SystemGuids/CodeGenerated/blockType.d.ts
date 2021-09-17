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

export const enum BlockType {
    /** Gets the Badges display block guid */
    Badges = "FC8AF928-C4AF-40C7-A667-4B24390F03A1",
    /** Gets the Plugin Manager guid */
    PluginManager = "F80268E6-2625-4565-AA2E-790C5E40A119",
    /** HTML Content Block Type Guid */
    HtmlContent = "19B61D65-37E3-459F-A44F-DEF0089118A3",
    /** Page Menu Block Type Guid */
    PageMenu = "CACB9D1A-A820-4587-986A-D66A69EE9948",
    /** Communication Detail Block Type Guid */
    CommunicationDetail = "CEDC742C-0AB3-487D-ABC2-77A0A443AEBF",
    /** Communication Entry (Simple) Block Type Guid */
    CommunicationEntry = "D9834641-7F39-4CFA-8CB2-E64068127565",
    /** The Communication Entry (Wizard) Block Type Guid */
    CommunicationEntryWizard = "F7D464E2-5F7C-47BA-84DB-7CC7B0B623C0",
    /** System Communication List Block Type Guid */
    SystemCommunicationList = "13BD5FCC-8F03-46B4-B193-E9C0987D2F20",
    /** System Communication Detail Block Type Guid */
    SystemCommunicationDetail = "8713F91A-8738-453D-AF13-3ED57F74137E",
    /** Mass Push Notifications Block Type Guid */
    MassPushNotifications = "D886DB44-0D0F-46D3-86AE-C959C520B0FD",
    /** The connection opportunity signup Block Type GUID */
    ConnectionOpportunitySignup = "C7FCE3B7-704B-43C0-AF96-5A70EB7F70D9",
    /** Content Channel View Block Type Guid */
    ContentChannelView = "143A2345-3E26-4ED0-A2FE-42AAF11B4C0F",
    /** Content Channel Item View Block Type Guid */
    ContentChannelItemView = "63659EBE-C5AF-4157-804A-55C7D565110E",
    /** Content Channel Navigation Block Type Guid */
    ContentChannelNavigation = "0E023AE3-BF08-48E0-93F8-08C32EB5CAFA",
    /** Content Component Block Type Guid */
    ContentComponent = "AD802CA1-842C-47F0-B5E9-739FE2B4A2BD",
    /** The PowerBI Account Registration Block Type Guid */
    PowerbiAccountRegistration = "EA20D87E-ED46-3DAA-4C4D-4156C399B1C2",
    /** Event category Registration Group Placement block type guid */
    EventRegistrationGroupPlacement = "9AF434D2-FB9B-43D7-8550-DD0B92B7A70A",
    /** Event category Registration Template Detail block type guid */
    EventRegistrationTemplateDetail = "91354899-304E-44C7-BD0D-55F42E6505D3",
    /** The Convert Business Block Type Guid */
    ConvertBusiness = "115A7725-6760-4E86-8171-57F4A3CF6909",
    /** The bulk update block type guid */
    BulkUpdate = "A844886D-ED6F-4367-9C6F-667401201ED0",
    /** The assessment list block type guid */
    AssessmentList = "0AD1D108-4ABF-4AED-B3B7-4AAEA16D10E4",
    /** The conflict profile block type guid */
    ConflictProfile = "91473D2F-607D-4260-9C6A-DD3762FE472D",
    /** The disc block type guid */
    Disc = "A161D12D-FEA7-422F-B00E-A689629680E4",
    /** The eq inventory block type guid */
    EqInventory = "040CFD6D-5155-4BC9-BAEE-A53219A7BECE",
    /** The gifts assessment block type guid */
    GiftsAssessment = "A7E86792-F0ED-46F2-988D-25EBFCD1DC96",
    /** The motivators block type guid */
    Motivators = "18CF8DA8-5DE0-49EC-A279-D5507CFA5713",
    /** Groups category Group Member Detail block type guid */
    GroupsGroupMemberDetail = "AAE2E5C3-9279-4AB0-9682-F4D19519D678",
    /** Groups category Group Member List block type guid */
    GroupsGroupMemberList = "88B7EFA9-7419-4D05-9F88-38B936E61EDD",
    /** RSVP category List block type guid. */
    RsvpList = "16CE8B41-FD1B-43F2-8C8E-4E878470E8BD",
    /** RSVP category Detail block type guid. */
    RsvpDetail = "2BC5CC6B-3618-4848-BCD9-1796AA35E7FD",
    /** RSVP category Response block type guid. */
    RsvpResponse = "EEFD83FB-6EE1-44F4-A012-7569F979CD6B",
    /** The log viewer */
    LogViewer = "6059FC03-E398-4359-8632-909B63FFA550",
    /** The phone number lookup block type. */
    PhoneNumberLookup = "51BB37DA-6F3E-40EC-B80E-D381E13E01B2",
    /** The oidc authorize */
    OidcAuthorize = "D9E2BE51-6AC2-43D6-BE63-9E5EC571BD95",
    /** The oidc logout */
    OidcLogout = "32F2171C-4CD2-48A0-AAD0-AE681CB0D2DD",
    /** The oidc scope list */
    OidcScopeList = "0E407FC8-B5B9-488E-81E4-8EA5F7CFCAB3",
    /** The oidc scope detail */
    OidcScopeDetail = "AA4368BD-00FA-4AB9-9591-CFD64BE6C9EA",
    /** The oidc claims */
    OidcClaims = "142BE80B-5FB2-459D-AE5C-E371C79538F6",
    /** The oidc client list */
    OidcClientList = "616D1A98-067D-43B8-B7F5-41FB12FB894E",
    /** The oidc client detail */
    OidcClientDetail = "312EAD0E-4068-4211-8410-2EB45B7D8BAB",
    /** The notes */
    Notes = "2E9F32D4-B4FC-4A5F-9BE1-B2E3EA624DD3",
    /** The group attendance detail */
    GroupAttendanceDetail = "FC6B5DC8-3A90-4D78-8DC2-7F7698A6E73B",
    /** The group attendance list */
    GroupAttendanceList = "5C547728-38C2-420A-8602-3CDAAC369247",
    /** The attendance self entry */
    AttendanceSelfEntry = "A5ECE422-D473-4B8F-BEE9-5651AFCB2AB3",
    /** Workflow Entry */
    WorkflowEntry = "A8BD05C8-6F89-4628-845B-059E686F089A",
    /** The Checkin Manager En Route */
    CheckInManagerEnRoute = "BC86F18C-9F38-4CA3-8CF9-5A837CBC700D",
    /** The contribution statement lava (Legacy) */
    ContributionStatementLavaLegacy = "AF986B72-ADD9-4E05-971F-1DE4EBED8667",
}

