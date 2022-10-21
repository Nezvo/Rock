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

/** RegistrationTemplateDiscount View Model */
export type RegistrationTemplateDiscountBag = {
    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets a value indicating whether the discount applies automatically. */
    autoApplyDiscount: boolean;

    /** Gets or sets the code. */
    code?: string | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets the discount amount. */
    discountAmount: number;

    /** Gets or sets the discount percentage. */
    discountPercentage: number;

    /** Gets or sets the last day that the discount code can be used */
    endDate?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets the maximum number of registrants per registration that the discount code can used for. */
    maxRegistrants?: number | null;

    /** Gets or sets the maximum number of registrations that can use this discount code. */
    maxUsage?: number | null;

    /** Gets or sets the minimum number of registrants a registration is required to have in order to be able to use this discount code. */
    minRegistrants?: number | null;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the order. */
    order: number;

    /** Gets or sets the Rock.Model.RegistrationTemplate identifier. */
    registrationTemplateId: number;

    /** Gets or sets the first day that the discount code can be used. */
    startDate?: string | null;
};
