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

import { FieldFilterSourceType } from "@Obsidian/Enums/Reporting/fieldFilterSourceType";
import { Guid } from "@Obsidian/Types";
import { FieldFilterPropertyBag } from "@Obsidian/ViewModels/Reporting/fieldFilterPropertyBag";
import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

/**
 * Describes a single source item an individual can pick from when building
 * a custom filter. This contains the information required to determine the
 * name to display, how to identify the source value and any other information
 * required to build the filter UI.
 */
export type FieldFilterSourceBag = {
    /** Gets or sets the attribute if the source type is Attribute. */
    attribute?: PublicAttributeBag | null;

    /**
     * Groups sources together visually in the source field picker when
     * painting the UI for editing filter rules.
     */
    category?: string | null;

    /** Gets or sets the unique identifier of this source item. */
    guid: Guid;

    /** Gets or sets the property if the source type is Property. */
    property?: FieldFilterPropertyBag | null;

    /**
     * Gets or sets the type of this source item. This indicates which
     * other properties are valid for inspection.
     */
    type: FieldFilterSourceType;
};
