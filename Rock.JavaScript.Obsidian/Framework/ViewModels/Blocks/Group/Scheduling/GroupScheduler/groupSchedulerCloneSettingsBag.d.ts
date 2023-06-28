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

/** The clone settings to indicate how group schedules should be cloned. */
export type GroupSchedulerCloneSettingsBag = {
    /** Gets or sets the available destination dates. */
    availableDestinationDates?: ListItemBag[] | null;

    /** Gets or sets the available groups. */
    availableGroups?: ListItemBag[] | null;

    /** Gets or sets the available locations. */
    availableLocations?: ListItemBag[] | null;

    /** Gets or sets the available schedules. */
    availableSchedules?: ListItemBag[] | null;

    /** Gets or sets the available source dates. */
    availableSourceDates?: ListItemBag[] | null;

    /** Gets or sets the ISO 8601 selected destination date. */
    selectedDestinationDate?: string | null;

    /** Gets or sets the selected groups. */
    selectedGroups?: string[] | null;

    /** Gets or sets the selected locations. */
    selectedLocations?: string[] | null;

    /** Gets or sets the selected schedules. */
    selectedSchedules?: string[] | null;

    /** Gets or sets the ISO 8601 selected source date. */
    selectedSourceDate?: string | null;
};
