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

/**
 * Class PersistedDatasetBag.
 * Implements the Rock.ViewModels.Utility.EntityBagBase
 */
export type PersistedDatasetBag = {
    /** Gets or sets the unique key to use to access this persisted dataset */
    accessKey?: string | null;

    /** Gets or sets a value indicating whether [allow manual refresh]. */
    allowManualRefresh: boolean;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the build script. See Rock.Model.PersistedDataset.BuildScriptType */
    buildScript?: string | null;

    /** Gets or sets a user defined description of the PersistedDataset. */
    description?: string | null;

    /** Gets or sets a comma-delimited list of enabled LavaCommands */
    enabledLavaCommands?: ListItemBag[] | null;

    /** Gets or sets the type of the entity. */
    entityType?: ListItemBag | null;

    /** The DateTime when to stop updating the Rock.Model.PersistedDataset.ResultData */
    expireDateTime?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a value indicating whether this instance is active. */
    isActive: boolean;

    /** Gets or sets the persisted last refresh date time. */
    lastRefreshDateTime?: string | null;

    /** Gets or sets the memory cache duration ms. */
    memoryCacheDurationHours?: number | null;

    /** Gets or sets the Name of the PersistedDataset. */
    name?: string | null;

    /** Gets or sets the refresh interval minutes */
    refreshIntervalHours?: number | null;
};
