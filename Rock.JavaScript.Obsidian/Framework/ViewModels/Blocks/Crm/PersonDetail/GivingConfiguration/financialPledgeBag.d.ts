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

import { Guid } from "@Obsidian/Types";
import { FinancialAccountBag } from "@Obsidian/ViewModels/Blocks/Crm/PersonDetail/GivingConfiguration/financialAccountBag";
import { PersonAliasBag } from "@Obsidian/ViewModels/Blocks/Crm/PersonDetail/GivingConfiguration/personAliasBag";

/** Contains all the financial pledge data for the person or business. */
export type FinancialPledgeBag = {
    /** Gets or sets the account for the financial pledge. */
    account?: FinancialAccountBag | null;

    /** Gets or sets the end date of the financial pledge. */
    endDate?: string | null;

    /** Gets or sets the GUID of the financial pledge. */
    guid: Guid;

    /** Gets or sets the identifier of the financial pledge. */
    id: number;

    /** Gets or sets the person alias for the financial pledge. */
    personAlias?: PersonAliasBag | null;

    /** Gets or sets the pledge frequency value of the financial pledge. */
    pledgeFrequencyValue?: string | null;

    /** Gets or sets the frequency value identifier of the financial pledge. */
    pledgeFrequencyValueId?: number | null;

    /** Gets or sets the start date of the financial pledge. */
    startDate?: string | null;

    /** Gets or sets the total amount of the financial pledge. */
    totalAmount: number;
};
