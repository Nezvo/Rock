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

/** The additional configuration options for the Event Item Occurrence List block. */
export type EventItemOccurrenceListOptionsBag = {
    /** Gets or sets available campus items for the Campus filter. */
    campusItems?: ListItemBag[] | null;

    /** Gets or sets the content item detail page URL from the block settings */
    contentItemDetailPageUrl?: string | null;

    /** Gets or sets the group detail page URL from the block settings. */
    groupDetailPageUrl?: string | null;

    /** Gets or sets a value indicating whether the block should be displayed to the user. */
    isBlockVisible: boolean;

    /** Gets or sets the registration instance page URL from the block settings. */
    registrationInstancePageUrl?: string | null;
};
