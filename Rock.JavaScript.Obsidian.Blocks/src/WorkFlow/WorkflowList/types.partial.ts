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

export const enum NavigationUrlKey {
    DetailPage = "DetailPage",
    EntryPage = "EntryPage",
}

export const enum PreferenceKey {
    FilterName = "filter-name",
    FilterInitiator = "filter-initiator",
    FilterStatus = "filter-status",
    FilterActivatedDateRangeUpperValue = "filter-activated-date-range-upper-value",
    FilterActivatedDateRangeLowerValue = "filter-activated-date-range-lower-value",
    FilterCompletedDateRangeUpperValue = "filter-completed-date-range-upper-value",
    FilterCompletedDateRangeLowerValue = "filter-completed-date-range-lower-value",
    FilterState = "filter-state",
}

export type GridSettingsOptions = {
    name?: string | null;

    initiator?: ListItemBag;

    status?: string | null;

    activatedDateRangeUpperValue?: string | null;

    activatedDateRangeLowerValue?: string | null;

    completedDateRangeUpperValue?: string | null;

    completedDateRangeLowerValue?: string | null;

    state?: string[];
};