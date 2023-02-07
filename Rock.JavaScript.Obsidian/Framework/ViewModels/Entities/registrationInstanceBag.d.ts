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

import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

/** RegistrationInstance View Model */
export type RegistrationInstanceBag = {
    /** Gets or sets the account identifier. */
    accountId?: number | null;

    /** Gets or sets the additional confirmation details. */
    additionalConfirmationDetails?: string | null;

    /** Gets or sets the additional reminder details. */
    additionalReminderDetails?: string | null;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the contact email. */
    contactEmail?: string | null;

    /** Gets or sets the name of the contact. */
    contactPersonAliasId?: number | null;

    /** Gets or sets the contact phone. */
    contactPhone?: string | null;

    /** Gets or sets the cost (if Rock.Model.RegistrationTemplate.SetCostOnInstance == true). */
    cost?: number | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /**
     * Gets or sets the default amount to pay per registrant (if Rock.Model.RegistrationTemplate.SetCostOnInstance == true).
     * If this is null, the default payment will be the Rock.Model.RegistrationInstance.Cost
     */
    defaultPayment?: number | null;

    /** Gets or sets the details. */
    details?: string | null;

    /** Gets or sets the end date time. */
    endDateTime?: string | null;

    /** Gets or sets the external gateway fund identifier. */
    externalGatewayFundId?: number | null;

    /** Gets or sets the external gateway merchant identifier. */
    externalGatewayMerchantId?: number | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a value indicating whether this instance is active. */
    isActive: boolean;

    /** Gets or sets the maximum attendees. */
    maxAttendees?: number | null;

    /** Gets or sets the minimum initial payment (if Rock.Model.RegistrationTemplate.SetCostOnInstance == true). */
    minimumInitialPayment?: number | null;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the name. */
    name?: string | null;

    /** Gets or sets the registration instructions. */
    registrationInstructions?: string | null;

    /** Gets or sets the registration metering threshold. */
    registrationMeteringThreshold?: number | null;

    /** Gets or sets the Rock.Model.RegistrationTemplate identifier. */
    registrationTemplateId: number;

    /** Optional workflow type to launch at end of registration */
    registrationWorkflowTypeId?: number | null;

    /** Gets or sets a value indicating whether [reminder sent]. */
    reminderSent: boolean;

    /** Gets or sets the send reminder date time. */
    sendReminderDateTime?: string | null;

    /** Gets or sets the start date time. */
    startDateTime?: string | null;

    /**
     * Gets or sets a value indicating whether [timeout is enabled].
     * Is there a time limit for a user submitting a registration? Their spot will be reserved until they submit
     * or the session times out.
     */
    timeoutIsEnabled: boolean;

    /**
     * Gets or sets the timeout length minutes. The amount of minutes that a spot will be held for a registrant
     * until they submit or timeout occurs.
     */
    timeoutLengthMinutes?: number | null;

    /**
     * Gets or sets the timeout threshold. The lower limit of available registrations before the checkout timer
     * is enabled. The checkout timer functionality will only display when there are fewer available registrations
     * than configured.
     */
    timeoutThreshold?: number | null;
};
