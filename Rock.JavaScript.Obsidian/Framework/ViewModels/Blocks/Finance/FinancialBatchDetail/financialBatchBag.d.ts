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

import { ListItemBag } from "@Obsidian/ViewModels/Utility/listItemBag";
import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

export type FinancialBatchBag = {
    /** Gets or sets an optional transaction code from an accounting system that batch is associated with */
    accountingSystemCode?: string | null;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /**
     * Gets or sets end of the posting date and time range for FinancialTransactions that are included in this batch.
     * Transactions that post before or on this date and time and after the Rock.Model.FinancialBatch.BatchStartDateTime can be included in this batch.
     */
    batchEndDateTime?: string | null;

    /**
     * Gets or sets the start posting date and time range of FinancialTransactions that are included in this batch.  
     * Transactions that post on or after this date and time and before the Rock.Model.FinancialBatch.BatchEndDateTime can be included in this batch.
     */
    batchStartDateTime?: string | null;

    /** Gets or sets the Rock.Model.Campus that this batch is associated with. */
    campus?: ListItemBag | null;

    /**
     * Gets or sets the control amount. This should match the total value of all
     * FinancialTransactions that are included in the batch.
     * Use Rock.Model.FinancialBatchService.IncrementControlAmount(System.Int32,System.Decimal,Rock.Model.History.HistoryChangeList) if you are incrementing the control amount
     * based on a transaction amount.
     */
    controlAmount: number;

    /** Gets or sets the control item count. */
    controlItemCount?: number | null;

    /**
     * The Batch ID
     * Motive: Although the IdKey is passed to the user, there is no way to get the id from it in the frontend
     * Id is required to be displayed in the frontend and so is included.
     */
    id: number;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets the value of the flag which shows if the batch is automated or not. */
    isAutomated: boolean;

    /** The flag which is set to true if the user is forbidden from reopening the batch */
    isReopenDisabled: boolean;

    /** Gets or sets the name of the batch. */
    name?: string | null;

    /** Gets or sets the note. */
    note?: string | null;

    /** Gets or sets the status of the batch. */
    status?: number | null;
};
