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

import { CurrencyInfoBag } from "@Obsidian/ViewModels/Utility/currencyInfoBag";
import { ListItemBag } from "@Obsidian/ViewModels/Utility/listItemBag";

/** Additional Configuration for the Benevolence Request List Block. */
export type BenevolenceRequestListOptionsBag = {
    /** Gets or sets the benevolence types for the benevolence type filter dropdown. */
    benevolenceTypes?: ListItemBag[] | null;

    /** Gets or sets a value indicating whether the current user has the administrate permission. */
    canAdministrate: boolean;

    /** Gets or sets the case workers for the case worker filter dropdown. */
    caseWorkers?: ListItemBag[] | null;

    /** Gets or sets the columns to hide. */
    columnsToHide?: string[] | null;

    /** Gets or sets the currency information. */
    currencyInfo?: CurrencyInfoBag | null;
};
