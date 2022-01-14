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
    /// Base client model for FinancialScheduledTransaction that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class FinancialScheduledTransactionEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int AuthorizedPersonAliasId { get; set; }

        /// <summary />
        public DateTime? CardReminderDate { get; set; }

        /// <summary />
        public DateTime? EndDate { get; set; }

        /// <summary />
        public int? FinancialGatewayId { get; set; }

        /// <summary />
        public int? FinancialPaymentDetailId { get; set; }

        /// <summary />
        public int? ForeignCurrencyCodeValueId { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string GatewayScheduleId { get; set; }

        /// <summary />
        public DateTime? InactivateDateTime { get; set; }

        /// <summary />
        public bool IsActive { get; set; } = true;

        /// <summary />
        public DateTime? LastRemindedDate { get; set; }

        /// <summary />
        public DateTime? LastStatusUpdateDateTime { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public DateTime? NextPaymentDate { get; set; }

        /// <summary />
        public int? NumberOfPayments { get; set; }

        /// <summary />
        public string PreviousGatewayScheduleIdsJson { get; set; }

        /// <summary />
        public int? SourceTypeValueId { get; set; }

        /// <summary />
        public DateTime StartDate { get; set; }

        /// <summary />
        public Rock.Client.Enums.FinancialScheduledTransactionStatus? Status { get; set; }

        /// <summary />
        public string StatusMessage { get; set; }

        /// <summary />
        public string Summary { get; set; }

        /// <summary />
        public string TransactionCode { get; set; }

        /// <summary />
        public int TransactionFrequencyValueId { get; set; }

        /// <summary />
        public int? TransactionTypeValueId { get; set; }

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
        /// Copies the base properties from a source FinancialScheduledTransaction object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( FinancialScheduledTransaction source )
        {
            this.Id = source.Id;
            this.AuthorizedPersonAliasId = source.AuthorizedPersonAliasId;
            this.CardReminderDate = source.CardReminderDate;
            this.EndDate = source.EndDate;
            this.FinancialGatewayId = source.FinancialGatewayId;
            this.FinancialPaymentDetailId = source.FinancialPaymentDetailId;
            this.ForeignCurrencyCodeValueId = source.ForeignCurrencyCodeValueId;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.GatewayScheduleId = source.GatewayScheduleId;
            this.InactivateDateTime = source.InactivateDateTime;
            this.IsActive = source.IsActive;
            this.LastRemindedDate = source.LastRemindedDate;
            this.LastStatusUpdateDateTime = source.LastStatusUpdateDateTime;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.NextPaymentDate = source.NextPaymentDate;
            this.NumberOfPayments = source.NumberOfPayments;
            this.PreviousGatewayScheduleIdsJson = source.PreviousGatewayScheduleIdsJson;
            this.SourceTypeValueId = source.SourceTypeValueId;
            this.StartDate = source.StartDate;
            this.Status = source.Status;
            this.StatusMessage = source.StatusMessage;
            this.Summary = source.Summary;
            this.TransactionCode = source.TransactionCode;
            this.TransactionFrequencyValueId = source.TransactionFrequencyValueId;
            this.TransactionTypeValueId = source.TransactionTypeValueId;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for FinancialScheduledTransaction that includes all the fields that are available for GETs. Use this for GETs (use FinancialScheduledTransactionEntity for POST/PUTs)
    /// </summary>
    public partial class FinancialScheduledTransaction : FinancialScheduledTransactionEntity
    {
        /// <summary />
        public FinancialGateway FinancialGateway { get; set; }

        /// <summary />
        public FinancialPaymentDetail FinancialPaymentDetail { get; set; }

        /// <summary />
        public DefinedValue ForeignCurrencyCodeValue { get; set; }

        /// <summary />
        public ICollection<FinancialScheduledTransactionDetail> ScheduledTransactionDetails { get; set; }

        /// <summary />
        public DefinedValue SourceTypeValue { get; set; }

        /// <summary />
        public DefinedValue TransactionFrequencyValue { get; set; }

        /// <summary />
        public ICollection<FinancialTransaction> Transactions { get; set; }

        /// <summary />
        public DefinedValue TransactionTypeValue { get; set; }

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
