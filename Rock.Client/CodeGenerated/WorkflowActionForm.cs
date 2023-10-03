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
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for WorkflowActionForm that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class WorkflowActionFormEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public Guid? ActionAttributeGuid { get; set; }

        /// <summary />
        public string Actions { get; set; }

        /// <summary />
        public bool? AllowNotes { get; set; }

        /// <summary />
        public bool AllowPersonEntry { get; set; }

        /// <summary />
        public string Footer { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string Header { get; set; }

        /// <summary />
        public bool IncludeActionsInNotification { get; set; } = true;

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public int? NotificationSystemCommunicationId { get; set; }

        /// <summary />
        // Made Obsolete in Rock "1.10"
        [Obsolete( "Use NotificationSystemCommunicationId instead.", true )]
        public int? NotificationSystemEmailId { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryAddressEntryOption { get; set; }

        /// <summary />
        public bool PersonEntryAutofillCurrentPerson { get; set; } = true;

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryBirthdateEntryOption { get; set; }

        /// <summary />
        public bool PersonEntryCampusIsVisible { get; set; } = true;

        /// <summary />
        public int? PersonEntryCampusStatusValueId { get; set; }

        /// <summary />
        public int? PersonEntryCampusTypeValueId { get; set; }

        /// <summary />
        public int? PersonEntryConnectionStatusValueId { get; set; }

        /// <summary />
        public string PersonEntryDescription { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryEmailEntryOption { get; set; } = Rock.Client.Enums.WorkflowActionFormPersonEntryOption.Required;

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryEthnicityEntryOption { get; set; }

        /// <summary />
        public Guid? PersonEntryFamilyAttributeGuid { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryGenderEntryOption { get; set; } = Rock.Client.Enums.WorkflowActionFormPersonEntryOption.Required;

        /// <summary />
        public int? PersonEntryGroupLocationTypeValueId { get; set; }

        /// <summary />
        public bool PersonEntryHideIfCurrentPersonKnown { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryMaritalStatusEntryOption { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryMobilePhoneEntryOption { get; set; }

        /// <summary />
        public Guid? PersonEntryPersonAttributeGuid { get; set; }

        /// <summary />
        public string PersonEntryPostHtml { get; set; }

        /// <summary />
        public string PersonEntryPreHtml { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntryRaceEntryOption { get; set; }

        /// <summary />
        public int? PersonEntryRecordStatusValueId { get; set; }

        /// <summary />
        public int? PersonEntrySectionTypeValueId { get; set; }

        /// <summary />
        public bool PersonEntryShowHeadingSeparator { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormShowHideOption PersonEntrySmsOptInEntryOption { get; set; }

        /// <summary />
        public Guid? PersonEntrySpouseAttributeGuid { get; set; }

        /// <summary />
        public Rock.Client.Enums.WorkflowActionFormPersonEntryOption PersonEntrySpouseEntryOption { get; set; }

        /// <summary />
        public string PersonEntrySpouseLabel { get; set; } = @"Spouse";

        /// <summary />
        public string PersonEntryTitle { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// This does not need to be set or changed. Rock will always set this to the current date/time when saved to the database.
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source WorkflowActionForm object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( WorkflowActionForm source )
        {
            this.Id = source.Id;
            this.ActionAttributeGuid = source.ActionAttributeGuid;
            this.Actions = source.Actions;
            this.AllowNotes = source.AllowNotes;
            this.AllowPersonEntry = source.AllowPersonEntry;
            this.Footer = source.Footer;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.Header = source.Header;
            this.IncludeActionsInNotification = source.IncludeActionsInNotification;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.NotificationSystemCommunicationId = source.NotificationSystemCommunicationId;
            this.PersonEntryAddressEntryOption = source.PersonEntryAddressEntryOption;
            this.PersonEntryAutofillCurrentPerson = source.PersonEntryAutofillCurrentPerson;
            this.PersonEntryBirthdateEntryOption = source.PersonEntryBirthdateEntryOption;
            this.PersonEntryCampusIsVisible = source.PersonEntryCampusIsVisible;
            this.PersonEntryCampusStatusValueId = source.PersonEntryCampusStatusValueId;
            this.PersonEntryCampusTypeValueId = source.PersonEntryCampusTypeValueId;
            this.PersonEntryConnectionStatusValueId = source.PersonEntryConnectionStatusValueId;
            this.PersonEntryDescription = source.PersonEntryDescription;
            this.PersonEntryEmailEntryOption = source.PersonEntryEmailEntryOption;
            this.PersonEntryEthnicityEntryOption = source.PersonEntryEthnicityEntryOption;
            this.PersonEntryFamilyAttributeGuid = source.PersonEntryFamilyAttributeGuid;
            this.PersonEntryGenderEntryOption = source.PersonEntryGenderEntryOption;
            this.PersonEntryGroupLocationTypeValueId = source.PersonEntryGroupLocationTypeValueId;
            this.PersonEntryHideIfCurrentPersonKnown = source.PersonEntryHideIfCurrentPersonKnown;
            this.PersonEntryMaritalStatusEntryOption = source.PersonEntryMaritalStatusEntryOption;
            this.PersonEntryMobilePhoneEntryOption = source.PersonEntryMobilePhoneEntryOption;
            this.PersonEntryPersonAttributeGuid = source.PersonEntryPersonAttributeGuid;
            this.PersonEntryPostHtml = source.PersonEntryPostHtml;
            this.PersonEntryPreHtml = source.PersonEntryPreHtml;
            this.PersonEntryRaceEntryOption = source.PersonEntryRaceEntryOption;
            this.PersonEntryRecordStatusValueId = source.PersonEntryRecordStatusValueId;
            this.PersonEntrySectionTypeValueId = source.PersonEntrySectionTypeValueId;
            this.PersonEntryShowHeadingSeparator = source.PersonEntryShowHeadingSeparator;
            this.PersonEntrySmsOptInEntryOption = source.PersonEntrySmsOptInEntryOption;
            this.PersonEntrySpouseAttributeGuid = source.PersonEntrySpouseAttributeGuid;
            this.PersonEntrySpouseEntryOption = source.PersonEntrySpouseEntryOption;
            this.PersonEntrySpouseLabel = source.PersonEntrySpouseLabel;
            this.PersonEntryTitle = source.PersonEntryTitle;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for WorkflowActionForm that includes all the fields that are available for GETs. Use this for GETs (use WorkflowActionFormEntity for POST/PUTs)
    /// </summary>
    public partial class WorkflowActionForm : WorkflowActionFormEntity
    {
        /// <summary />
        public ICollection<WorkflowActionFormAttribute> FormAttributes { get; set; }

        /// <summary />
        public ICollection<WorkflowActionFormSection> FormSections { get; set; }

        /// <summary />
        public DefinedValue PersonEntryCampusStatusValue { get; set; }

        /// <summary />
        public DefinedValue PersonEntryCampusTypeValue { get; set; }

        /// <summary />
        public DefinedValue PersonEntryConnectionStatusValue { get; set; }

        /// <summary />
        public DefinedValue PersonEntryGroupLocationTypeValue { get; set; }

        /// <summary />
        public DefinedValue PersonEntryRecordStatusValue { get; set; }

        /// <summary />
        public DefinedValue PersonEntrySectionTypeValue { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
