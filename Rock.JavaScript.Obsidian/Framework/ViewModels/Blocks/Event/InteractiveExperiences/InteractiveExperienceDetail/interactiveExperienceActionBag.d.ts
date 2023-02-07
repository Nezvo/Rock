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
import { ListItemBag } from "@Obsidian/ViewModels/Utility/listItemBag";

/** Identifies a single action configured for use with an interactive experience. */
export type InteractiveExperienceActionBag = {
    /** Gets or sets the type of action. */
    actionType?: ListItemBag | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the unique identifier of this action instance. */
    guid?: Guid | null;

    /**
     * Gets or sets a value indicating whether moderation is required
     * for this action.
     */
    isModerationRequired: boolean;

    /**
     * Gets or sets a value indicating whether multiple submissions are
     * allowed for this action.
     */
    isMultipleSubmissionsAllowed: boolean;

    /**
     * Gets or sets a value indicating whether this action should record
     * responses anonymously.
     */
    isResponseAnonymous: boolean;

    /** Gets or sets the response visualizer used to display responses. */
    responseVisualizer?: ListItemBag | null;

    /** Gets or sets the title of this action. */
    title?: string | null;
};
