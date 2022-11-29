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

/** System file types. */
export const enum Attribute {
    /** The binaryfiletype filestorage rootpath attribute */
    BinaryfiletypeFilestorageRootpath = "3CAFA34D-9208-439B-A046-CB727FB729DE",
    /** The global email link preference */
    GlobalEmailLinkPreference = "F1BECEF9-1047-E89F-4CC8-8F856750E5D0",
    /** The global enabled lava commands */
    GlobalEnabledLavaCommands = "933CFB7D-C9E1-BDAE-40AD-231002A91626",
    /** The global enable giving envelope feature */
    GlobalEnableGivingEnvelope = "805698B0-BED7-4183-8FC6-3BDBF9E49EF1",
    /** The default short link site */
    GlobalDefaultShortLinkSite = "DD0E0757-2A01-47BB-A74A-F6E69B0399C8",
    /** The Google reCaptcha site key */
    GlobalGoogleRecaptchaSiteKey = "BF1FD484-50F3-4C7E-975C-5E1CEB1F8C72",
    /** The Google reCaptcha secret key */
    GlobalGoogleRecaptchaSecretKey = "D36E5760-05FF-479F-AD1D-C048AE2E99E9",
    /** The Google reCaptcha secret key */
    GlobalPublicApplicationRoot = "49AD7AD6-9BAC-4743-B1E8-B917F6271924",
    /** The Liquid Framework used to parse and render Lava. */
    GlobalLavaEngineLiquidFramework = "9CBDD352-A4F5-47D6-9EFE-6115774B2DFE",
    /** The Facebook link attribute */
    PersonFacebook = "2B8A03D3-B7DC-4DA3-A31E-826D655435D5",
    /** The Twitter link attribute */
    PersonTwitter = "12E9C8A7-03E4-472D-9E20-9EC8F3453B2F",
    /** The Instagram link attribute */
    PersonInstagram = "8796567C-4047-43C1-AF32-2FDBE030BEAC",
    /** The SnapChat link attribute */
    PersonSnapchat = "61099377-9EB3-43EA-BA37-75E329E55866",
    /** The allergy attribute */
    PersonAllergy = "DBD192C9-0AA1-46EC-92AB-A3DA8E056D31",
    /** The Person legal note attribute */
    PersonLegalNote = "F832AB6F-B684-4EEA-8DB4-C54B895C79ED",
    /** The person attribute for the person's giving envelope number */
    PersonGivingEnvelopeNumber = "76C33FBC-8799-4DF1-B2FE-A6C41AC3DD49",
    /** The same site cookie setting */
    SameSiteCookieSetting = "03F55022-C1E0-45F3-84E1-C2BE8C38E22B",
    /** The attribute that stores the date the person took the DISC test */
    PersonDiscLastSaveDate = "990275DB-611B-4D2E-94EA-3FFA1186A5E1",
    /** The person attribute for the DISC profile */
    PersonDiscProfile = "6EAC3DF8-CA81-41A5-B1CF-A8DD7BD42F8D",
    /** The person attribute for the dominant gifts */
    PersonDominantGifts = "F76FC75E-B33F-42B8-B360-15BA9A1F0F9A",
    /** The person attribute for the supportive gifts */
    PersonSupportiveGifts = "0499E359-3A7B-4138-A3EE-44CBF9750E33",
    /** The person attribute for the other gifts */
    PersonOtherGifts = "F33EC30E-7E5C-488E-AB48-81977CCFB185",
    /** The person attribute for the spiritual gifts */
    PersonSpiritualGiftsLastSaveDate = "3668547C-3DC4-450B-B92D-4B98A693A371",
    /** The person attribute for the conflict mode: winning */
    PersonConflictModeWinning = "7147F706-388E-45E6-BE21-893FC7D652AA",
    /** The person attribute for the conflict mode: resolving */
    PersonConflictModeResolving = "5B811EAC-51B2-41F2-A55A-C966D9DB05EE",
    /** The person attribute for the conflict mode: compromising */
    PersonConflictModeCompromising = "817D6B13-E4AA-4E93-8547-FE711A0065F2",
    /** The person attribute for the conflict mode: avoiding */
    PersonConflictModeAvoiding = "071A8EFA-AD1C-436A-8E1E-23D215617004",
    /** The person attribute for the conflict mode: yielding */
    PersonConflictModeYielding = "D30A33AD-7A60-43E0-84DA-E23600156BF7",
    /** The person attribute for the conflict engagement profile: accommodating */
    PersonConflictThemeAccommodating = "404A64FB-7396-4896-9C94-84DE21E995CA",
    /** The person attribute for the conflict engagement profile: winning */
    PersonConflictThemeWinning = "6DE5878D-7CDB-404D-93A7-27CFF5E98C3B",
    /** The person attribute for the conflict engagement profile: solving */
    PersonConflictThemeSolving = "33235605-D8BB-4C1E-B231-6F085970A14F",
    /** The person attribute for the EQ self aware */
    PersonEqConstructsSelfAwareness = "A5EFCE3E-EA41-4FEC-99F6-DD748A7D5BB5",
    /** The person attribute for the EQ self regulate */
    PersonEqConstructsSelfRegulating = "149CD0CD-3CD6-44B6-8D84-A17A477A8978",
    /** The person attribute for the EQ others aware */
    PersonEqConstructsOthersAwareness = "A6AF0BE5-E93A-49EB-AFEA-3520B7C41C78",
    /** The person attribute for the EQ others regulate */
    PersonEqConstructsOthersRegulating = "129C108E-CE61-4DFB-A9A8-1EBC3462022E",
    /** The person attribute for the EQ in problem solving */
    PersonEqScalesProblemSolving = "B598BF9C-7A0C-467E-B467-13B40DAC9F8D",
    /** The person attribute for the EQ under stress */
    PersonEqScalesUnderStress = "C3CB8FB5-34A2-48C8-B1FC-7CEBA670C1ED",
    /** The person attribute for the Motivator Believing */
    PersonMotivatorBeliving = "2045D752-2B7F-4314-A58D-AE77AE095CA8",
    /** The person attribute for the Motivator Caring */
    PersonMotivatorCaring = "95C6E9B1-4E26-4D7A-8944-3FED076C12B6",
    /** The person attribute for the Motivator Expressing */
    PersonMotivatorExpressing = "79CC222F-ABB0-489B-8DC3-20FA10A29ADE",
    /** The person attribute for the Motivator Empowering */
    PersonMotivatorEmpowering = "510523B0-E428-407A-8C6F-216ADD27CCE0",
    /** The person attribute for the Motivator Engaging */
    PersonMotivatorEngaging = "A3B93C89-8C89-431D-A408-7E8C209DF62A",
    /** The person attribute for the Motivator Adapting */
    PersonMotivatorAdapting = "7E32DC1C-D912-45AA-9C16-F098ED33A0D2",
    /** The person attribute for the Motivator Gathering */
    PersonMotivatorGathering = "2E6960AE-9381-457C-9191-C09CDCAC6FBB",
    /** The person attribute for the Motivator Innovating */
    PersonMotivatorInnovating = "B907EC74-CC86-4AEC-9A85-F46FA4152993",
    /** The person attribute for the Motivator Leading */
    PersonMotivatorLeading = "52652A3A-BE69-4956-B86A-40341481A57C",
    /** The person attribute for the Motivator Learning */
    PersonMotivatorLearning = "2579C27B-CE3F-4F2F-B413-1131781106BC",
    /** The person attribute for the Motivator Maximizing */
    PersonMotivatorMaximizing = "F0611197-79C6-4AA3-9BB8-3296604CDA2E",
    /** The person attribute for the Motivator Organizing */
    PersonMotivatorOrganizing = "8BA793F1-81B3-43D3-A096-79C3CF50D4C6",
    /** The person attribute for the Motivator Pacing */
    PersonMotivatorPacing = "DD20707F-155B-4784-9BEC-76894A2216A3",
    /** The person attribute for the Motivator Perceiving */
    PersonMotivatorPerceiving = "33DBCA52-367D-40CB-BB79-DB38D41E7CF4",
    /** The person attribute for the Motivator Relating */
    PersonMotivatorRelating = "60653130-E82A-472B-984E-11594547B26C",
    /** The person attribute for the Motivator Serving */
    PersonMotivatorServing = "C63CEF01-A942-445B-A27D-824FC6197F4E",
    /** The person attribute for the Motivator Thinking */
    PersonMotivatorThinking = "4AA4D77D-138D-45A8-827E-1644062BA5C2",
    /** The person attribute for the Motivator Transforming */
    PersonMotivatorTransforming = "EB185628-9F15-4BFB-BE75-9B08DA73CF7B",
    /** The person attribute for the Motivator Uniting */
    PersonMotivatorUniting = "D7A987CA-7DF6-4539-96F6-A3641C3F1DED",
    /** The person attribute for the Motivator Persevering */
    PersonMotivatorPersevering = "C4361DE6-6F62-446C-B4B3-39CB670AC0E1",
    /** The person attribute for the Motivator Venturing */
    PersonMotivatorRisking = "04ED7F11-4C01-43B6-9EF7-C5C4820055B0",
    /** The person attribute for the Motivator Visioning */
    PersonMotivatorVisioning = "C9BC83A0-27D4-4194-A199-56F2EA83363C",
    /** The person attribute to hold the top 5 motivators. */
    PersonMotivatorTop5Motivators = "402308F6-44BB-46CF-ADF9-6F62406C9923",
    /** The person attribute for the Motivator Growth Propensity */
    PersonMotivatorGrowthpropensity = "3BDBF9D3-F4DF-4E4C-A81D-64730217B6EA",
    /** The person attribute for the Motivator Relational Theme */
    PersonMotivatorsRelationalTheme = "CDCBA1D3-4129-43DB-9607-74F57BEBF807",
    /** The person attribute for the Motivator Directional Theme */
    PersonMotivatorDirectionalTheme = "0815E9BE-BC24-4568-AC1A-3ECCDFF44D9F",
    /** The person attribute for the Motivator Intellectual Theme */
    PersonMotivatorsIntellectualTheme = "592A5F89-5E8A-43D8-8843-760207D71699",
    /** The person attribute for the Motivator Positional Theme */
    PersonMotivatorPositionalTheme = "075FDF4D-DDEC-4106-B996-F48CD1EFC978",
    /** The eRA Currently an eRA attribute */
    PersonEraCurrentlyAnEra = "CE5739C5-2156-E2AB-48E5-1337C38B935E",
    /** The eRA start date attribute */
    PersonEraStartDate = "A106610C-A7A1-469E-4097-9DE6400FDFC2",
    /** The eRA end date attribute */
    PersonEraEndDate = "4711D67E-7526-9582-4A8E-1CD7BBE1B3A2",
    /** The eRA first attended attribute */
    PersonEraFirstCheckin = "AB12B3B0-55B8-D6A5-4C1F-DB9CCB2C4342",
    /** The eRA last attended attribute */
    PersonEraLastCheckin = "5F4C6462-018E-D19C-4AB0-9843CB21C57E",
    /** The eRA last gave attribute */
    PersonEraLastGave = "02F64263-E290-399E-4487-FC236F4DE81F",
    /** The eRA first gave attribute */
    PersonEraFirstGave = "EE5EC76A-D4B9-56B5-4B48-29627D945F10",
    /** The eRA times attended in the last 16 weeks attribute */
    PersonEraTimesCheckedin16 = "45A1E978-DC5B-CFA1-4AF4-EA098A24C914",
    /** The eRA times given in last 52 weeks attribute */
    PersonEraTimesGiven52 = "57700E8F-ED11-D787-415A-04DDF411BB10",
    /** The eRA times given in last 6 weeks attribute */
    PersonEraTimesGiven6 = "AC11EF53-AE55-79A0-4CAD-43721750E988",
    /** Group attribute to store the age range of the group */
    GroupAgeRange = "43511B8F-71D9-423A-85BF-D1CD08C1998E",
    /** Group attribute to store the birthdate range of the group */
    GroupBirthdateRange = "F1A43EAB-D682-403F-A05E-CCFFBF879F32",
    /** Communication Entry Wizard Block configuration setting. */
    CommunicationEntryWizardDefaultAsBulk = "23C883A6-AD9B-4C91-BAE6-16E0076C5D67",
    /** Communication Entry Block configuration setting. */
    CommunicationEntryDefaultAsBulk = "679E5FBB-AB03-4DE4-BB24-1C7CEFEACD3E",
    /** System Communication List/Detail Page configuration setting. */
    SystemCommunicationListDetailPage = "9880C186-F079-4113-99B6-EF53AB4FE92D",
    /** Group attribute for groups of GroupType CommunicationList to defined additional dataviews that can be used as communication segments */
    GroupCommunicationListSegments = "73A53BC1-2178-46A1-8413-C7A4DD49F0B4",
    /** Group attribute for groups of GroupType CommunicationList to define category */
    GroupCommunicationListCategory = "E3810936-182E-2585-4F8E-030A0E18B27A",
    /** The groupmember (of a communication list) preferred communication medium */
    GroupmemberCommunicationListPreferredCommunicationMedium = "D7941908-1F65-CC9B-416C-CCFABE4221B9",
    /** The communication transport SMTP server Attribute Guid */
    CommunicationTransportSmtpServer = "6CFFDF99-E93A-49B8-B440-0EF93878A51F",
    /** The communication medium Email CSS Inlining Enabled Attribute Guid */
    CommunicationMediumEmailCssInliningEnabled = "1D5E06A4-79BD-4554-AB63-DD6F1F815594",
    /** The Template DefinedType &gt; TemplateBlock DefinedValue Attribute Guid */
    DefinedTypeTemplateTemplateBlock = "0AAFF537-7EC6-4AA9-A987-68DA1FF8511D",
    /** The Template DefinedType &gt; Icon DefinedValue Attribute Guid */
    DefinedTypeTemplateIcon = "831403EB-262E-4BC5-8B5E-F16153493BF5",
    /** The Currency type DefinedType &gt; IconCssClass DefinedValue Attribute Guid */
    DefinedTypeCurrencyTypeIconcssclass = "CB1E9401-E1FD-4DBB-B15F-4E6994602723",
    /** The Transaction Source DefinedType &gt; IconCssClass DefinedValue Attribute Guid */
    DefinedTypeTransactionSourceIconcssclass = "9617D1DC-6561-4314-83EB-7F0ACBA2E259",
    /** The defined value attribute for storing if a device type supports cameras. */
    DefinedValueDeviceTypeSupportsCameras = "79D1D843-4641-458D-A20B-37E0D7B4AEBE",
    /** Country - Locality Label */
    CountryLocalityLabel = "1C234A6D-007F-4410-814E-13E9AE8654B4",
    /** Country Address Requirement Level for Address Line 1. */
    CountryAddressLine1Requirement = "8B7410F4-7EFB-4ABC-BFD0-B8A9A7ADB27D",
    /** Country Address Requirement Level for Address Line 2. */
    CountryAddressLine2Requirement = "0FCBA54C-0B88-45A8-9303-E9783F2A2D0E",
    /** Country Address Requirement Level for City. */
    CountryAddressCityRequirement = "EE9B4454-ACBF-416F-8080-2885A3CD6CA6",
    /** Country Address Requirement Level for Locality. */
    CountryAddressLocalityRequirement = "A0B0B033-9DA9-45F4-A593-B40EDCDB2D00",
    /** Country Address Requirement Level for State. */
    CountryAddressStateRequirement = "E488AE1D-FC76-44FE-A48D-271E6DF44C24",
    /** Country Address Requirement Level for Postal Code. */
    CountryAddressPostcodeRequirement = "0037453D-0D26-4F02-8AB3-6AD675D85AAE",
    /** The defined value attribute for storing a fundraising opportunity type's donation button text. */
    DefinedValueFundraisingDonateButtonText = "7ACD6580-0E5B-4407-BC8B-1BBBAF443B1E",
    /** The group attribute for the type of participation in a Fundraising Opportunity group. */
    ParticipationType = "EFA9F0D0-54CE-4B88-BC91-8BD110DEE0FC",
    /** The attribute for Transaction Header in the Fundraising Transaction Entry block. */
    FundraisingTransactionHeader = "65FB0B9A-670E-4AB9-9666-77959B4B702E",
    /** The bio block's workflow action attribute Guid */
    BioWorkflowaction = "7197A0FB-B330-43C4-8E62-F3C14F649813",
    /** Global attribute of image file type extensions that should be allowed. */
    ContentImageFiletypeWhitelist = "0F842054-7629-419F-BC72-90BDDE9F3676",
    /** Global attribute of file type extensions that should never be allowed. Has precedence over other lists. */
    ContentFiletypeBlacklist = "9FFB15C1-AA53-4FBA-A480-64C9B348C5E5",
    /** The content filetype whitelist. Has a lower precedence than CONTENT_FILETYPE_BLACKLIST */
    ContentFiletypeWhitelist = "B895B6D7-BA21-45C0-8913-EF47FAAD69B1",
    /** The defined value attribute for JWT issuer */
    DefinedValueJwtIssuer = "4B89D006-0523-4C77-A46B-7ECD042FDE99",
    /** The defined value attribute for JWT audience */
    DefinedValueJwtAudience = "6F9D9BFB-433F-4D77-8758-FBDB2011FB27",
    /** The defined value attribute for JWT person search key */
    DefinedValueJwtSearchKey = "DEECB6D1-E596-4A15-B0DB-B2947B5DB784",
    /** The Campus workflow action attribute guid for PersonGetCampusTeamMember */
    WorkflowActionPersonGetCampusTeamMemberCampus = "B07F920E-8450-4D1F-985D-6241E4F5E5CB",
    /** The Campus Role workflow action attribute guid for PersonGetCampusTeamMember */
    WorkflowActionPersonGetCampusTeamMemberCampusRole = "5F8F5E6B-5888-4834-B47B-36664FB3A96C",
    /** The Campus Team Member workflow action attribute guid for PersonGetCampusTeamMember */
    WorkflowActionPersonGetCampusTeamMemberCampusTeamMember = "7CFEDCB2-EA8F-421F-BA5E-B0D8BD10EA92",
    /** The Person workflow action attribute guid for PersonGetCampusTeamMember */
    WorkflowActionPersonGetCampusTeamMemberPerson = "C10C4C89-2B91-4D9A-8D5F-A3E65758A878",
    /** The Send Email workflow action attribute guid for FromEmailAddress */
    WorkflowActionSendEmailFromEmailAddress = "9F5F7CEC-F369-4FDF-802A-99074CE7A7FC",
    /** The Send Email workflow action attribute guid for SendToEmailAddresses */
    WorkflowActionSendEmailSendToEmailAddresses = "0C4C13B8-7076-4872-925A-F950886B5E16",
    /** The Send Email workflow action attribute guid for SendToGroupRole */
    WorkflowActionSendEmailSendToGroupRole = "D43C2686-7E02-4A70-8D99-3BCD8ECAFB2F",
    /** The Send Email workflow action attribute guid for Subject */
    WorkflowActionSendEmailSubject = "5D9B13B6-CD96-4C7C-86FA-4512B9D28386",
    /** The Send Email workflow action attribute guid for Body */
    WorkflowActionSendEmailBody = "4D245B9E-6B03-46E7-8482-A51FBA190E4D",
    /** The Send Email workflow action attribute guid for CcEmailAddresses */
    WorkflowActionSendEmailCcEmailAddresses = "99FFD423-2AB6-481B-8749-B4793A16B620",
    /** The Send Email workflow action attribute guid for BccEmailAddresses */
    WorkflowActionSendEmailBccEmailAddresses = "3A131021-CB73-44A8-A142-B42832B77F60",
    /** The Send Email workflow action attribute guid for AttachmentOne */
    WorkflowActionSendEmailAttachmentOne = "C2C7DA55-3018-4645-B9EE-4BCD11855F2C",
    /** The Send Email workflow action attribute guid for AttachmentTwo */
    WorkflowActionSendEmailAttachmentTwo = "FFD9193A-451F-40E6-9776-74D5DCAC1450",
    /** The Send Email workflow action attribute guid for AttachmentThree */
    WorkflowActionSendEmailAttachmentThree = "A059767A-5592-4926-948A-1065AF4E9748",
    /** The Send Email workflow action attribute guid for SaveCommunicationHistory */
    WorkflowActionSendEmailSaveCommunicationHistory = "65E69B78-37D8-4A88-B8AC-71893D2F75EF",
    /** The Workflow Entry Block Attribute that disables passing the WorkflowTypeID. */
    WorkflowEntryBlockDisablePassingWorkflowtypeid = "BA7D9988-E6C9-467E-8F08-E0282FE6F7CB",
    /** The Workflow Entry Block Attribute that disables passing the WorkflowID. */
    WorkflowEntryBlockDisablePassingWorkflowid = "890676BC-18D3-445F-A6FA-CC2F515F1930",
    /** The defined value logging domains to log */
    DefinedValueLoggingDomainsToLog = "9BEA544F-0636-485E-8772-B63180E529F9",
    /** The defined value log system settings */
    DefinedValueLogSystemSettings = "B9D4A315-8672-4214-B5D3-01A06C3CAD9F",
    /** The phone number lookup title */
    PhoneNumberLookupTitle = "7FD2383A-A2E8-4158-8E78-2E2E0C6CBA11",
    /** The phone number initial instructions */
    PhoneNumberInitialInstructions = "D9DFC4E4-A1F7-435C-8CF4-AD67CFA3F26E",
    /** The phone number verification instructions */
    PhoneNumberVerificationInstructions = "B14CA36A-CC8F-4858-A2B8-AE0966EDEF2D",
    /** The phone number individual selection instructions */
    PhoneNumberIndividualSelectionInstructions = "1DFA50D7-0819-4659-96DE-D25F80B880E5",
    /** The phone number not found message */
    PhoneNumberNotFoundMessage = "F752712B-C2CA-4541-8347-A632652E0764",
    /** The phone number authentication level */
    PhoneNumberAuthenticationLevel = "92C72C91-8670-4B1B-B529-F744EEE38B5A",
    /** The phone number verification time limit */
    PhoneNumberVerificationTimeLimit = "4569E05C-DE8F-40D4-8DF7-4DE6A564FF6E",
    /** The phone number ip throttle limit */
    PhoneNumberIpThrottleLimit = "2D148814-418A-45A3-9A98-1498363759E7",
    /** The phone number SMS number */
    PhoneNumberSmsNumber = "AE2979DF-EDE5-4389-ACBA-0FF7680BFE52",
    /** The phone number text message template */
    PhoneNumberTextMessageTemplate = "7F12E9B4-0CD1-42C8-AE68-457212B0B459",
    /** The oidc scope list detail page */
    OidcScopeListDetailPage = "4F4943D5-80D7-4472-B1D6-0AEA14B13CE1",
    /** The oidc client list detail page */
    OidcClientListDetailPage = "B889F2F5-800B-455C-A6E3-28E1AB6BE7BA",
    /** The oidc client list scope page */
    OidcClientListScopePage = "EF07798E-48D4-4261-97B2-501A8AD54E15",
    /** The Content Channel View Enable Archive Summary Attribute */
    EnableArchiveSummary = "753217FB-D519-44CC-83FC-C451E37E553F",
    /** The attendance type label */
    AttendanceTypeLabel = "6916359C-C168-4DBA-A893-365526C9F4C4",
    /** The configured attendance types */
    ConfiguredAttendanceTypes = "2CD11610-775B-44D4-BC0C-063563AC07E5",
    /** The display attendance type */
    DisplayAttendanceType = "41D650B3-78B8-4F02-AD58-B914914A72AE",
    /** The configured attendance type */
    ConfiguredAttendanceType = "D449AC5B-AC7A-457C-AD0F-D1DB1F73FC19",
    /** Preferred Currency - Defined Type */
    PersonGivingPreferredCurrency = "77A5F7DE-9096-45C8-9051-9D8EE50E3C2F",
    /** Preferred Source - Defined Type */
    PersonGivingPreferredSource = "0567B279-1F4D-4573-9AA7-927A7278443E",
    /** Frequency Label. See Rock.Financial.FinancialGivingAnalyticsFrequencyLabel. */
    PersonGivingFrequencyLabel = "1A58F7AA-238B-46E5-B1DC-0A5BC1F213A5",
    /** Percent of Gifts Scheduled - Integer */
    PersonGivingPercentScheduled = "98373264-0E65-4C79-B75B-4F8477AA647E",
    /** Gift Amount: Median - Currency */
    PersonGivingAmountMedian = "327F1CFF-A013-42B5-80A7-5922A40480EC",
    /**
     * Gift Amount: IQR - Currency
     * IQR = Interquartile Range calculated from the past 12 months of giving
     */
    PersonGivingAmountIqr = "CE129112-4BA9-4FC1-A67C-2A5C69140DA7",
    /** Gift Frequency Days: Mean -  Decimal */
    PersonGivingFrequencyMeanDays = "88E59B38-044C-4AE4-A455-A0D3A33DDEDA",
    /** Gift Frequency Days: Standard Deviation - Decimal */
    PersonGivingFrequencyStdDevDays = "1D5E4356-DC66-4067-BEF1-3560E61150BD",
    /** Giving Bin - Integer */
    PersonGivingBin = "7FBB63CC-F4FC-4F7E-A8C5-44DC3D0F0720",
    /** Giving Percentile - Integer - This will be rounded to the nearest percent and stored as a whole number (15 vs .15) */
    PersonGivingPercentile = "D03ACAB8-EB0C-4835-A04C-4C357014D935",
    /** Next Expected Gift Date - Date */
    PersonGivingNextExpectedGiftDate = "65D7CF79-BD80-44B2-9F5F-96D81B9B4990",
    /**
     * Last Classification Run Date Time - Date - sets the date time of then the giving unit was last classified.
     * Classification is updated after each new gift, but if they stop giving we’ll use this to occasionally update the classification.
     */
    PersonGivingLastClassificationDate = "7220B230-03CE-4D1E-985B-26AA28BE06F8",
    /**
     * Giving History JSON - Code - gets the JSON array of giving data by month objects.
     * [{ Year: 2020, Month: 1, AccountId: 1, Amount: 550.67 }, ...]
     */
    PersonGivingHistoryJson = "3BF34F25-4D50-4417-B436-37FEA3FA5473",
    /** Giving Total past 12 months - Currency */
    PersonGiving12Months = "ADD9BE86-49CA-46C4-B4EA-547F2F277294",
    /** Giving Total past 90 days - Currency */
    PersonGiving90Days = "0DE95B77-D26E-4513-9A71-92A7FD5C4B7C",
    /** Giving Total prior 90 days (90-180 days ago) - Currency */
    PersonGivingPrior90Days = "0170A267-942A-480A-A9CF-E4EA60CAA529",
    /** Gift count 12 month - Integer */
    PersonGiving12MonthsCount = "23B6A7BD-BBBB-4F2D-9695-2B1E03B3013A",
    /** Gift count 90 days - Integer */
    PersonGiving90DaysCount = "356B8F0B-AA54-4F44-8513-F8A5FF592F18",
    /** Giving Journey - Current Giving Journey Stage */
    PersonGivingCurrentGivingJourneyStage = "13C55AEA-6D88-4470-B3AE-EE5138F044DF",
    /** Giving Journey - Previous Giving Journey Stage */
    PersonGivingPreviousGivingJourneyStage = "B35CE867-6017-484E-9EC7-AEB93CD4B2D8",
    /** Giving Journey - Change Date of Giving Journey Stage */
    PersonGivingGivingJourneyStageChangeDate = "8FFE3554-43F2-40D8-8803-446559D2B1F7",
    /** Language in ISO639-1 */
    Iso6391 = "F5E8B6D2-6483-0F8D-4C20-07C51E7548AD",
    /** Language in ISO639 */
    Iso6392 = "09225D47-9A4D-D391-49E4-5A99A1DB47B8",
    /** The native language name */
    Nativelanguagename = "55256C99-DAC9-1AB4-4FD2-7CBFE3170245",
    /** The currency code symbol */
    CurrencyCodeSymbol = "1268AD58-5459-4C1C-A036-B7A6D948198F",
    /** The currency code position */
    CurrencyCodePosition = "909B35DA-5B14-42FF-90E5-328033A07415",
    /** The currency code decimal places */
    CurrencyCodeDecimalPlaces = "98699FDB-DFD3-4015-AB25-ABCB91EE35EB",
    /** The organization currency code */
    OrganizationCurrencyCode = "60B61A30-3FE8-4158-8848-D4D95DBC64CD",
    /** The person do not send giving statement */
    PersonDoNotSendGivingStatement = "B767F2CF-A4F0-45AA-A2E9-8270F31B307B",
    /** The accumulative achievement streak type */
    AccumulativeAchievementStreakType = "BEDD14D0-450E-475C-8D9F-404DDE350530",
    /** The accumulative achievement number to accumulate */
    AccumulativeAchievementNumberToAccumulate = "E286F5E1-356F-473A-AB80-A3BA3063703F",
    /** The accumulative achievement time span in days */
    AccumulativeAchievementTimeSpanInDays = "1C0F4BE1-81E9-4974-A24E-2DFBA8320AE5",
    /** The streak achievement streak type */
    StreakAchievementStreakType = "E926DAAE-980A-4BEE-9CF8-C3BF52F28D9D",
    /** The streak achievement number to achieve */
    StreakAchievementNumberToAchieve = "302BDD9E-5EAA-423B-AC1A-7E2067E70C19",
    /** The streak achievement time span in days */
    StreakAchievementTimeSpanInDays = "80030537-ED8E-41BA-BF61-AF242B9073CC",
    /** The statement generator configuration */
    StatementGeneratorConfig = "3C6B81A5-63AB-4EA7-A671-836505B9E444",
    /** The category treeview search results */
    CategoryTreeviewSearchResults = "7287F9CD-CDB2-43BA-8E80-E5F7A618415E",
}
