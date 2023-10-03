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

/**
 * Information about a single attribute field that has been defined on
 * the grid. Attributes are handled slightly differently than normal
 * fields so these are handled differently than regular
 * Rock.ViewModels.Core.Grid.FieldDefinitionBag objects.
 */
export type AttributeFieldDefinitionBag = {
    /**
     * Gets or sets the field type unique identifier. This is the field type
     * that provides logic for the attribute.
     */
    fieldTypeGuid?: Guid | null;

    /**
     * Gets or sets the name of the field. This corresponds to the key name
     * in the row data object.
     */
    name?: string | null;

    /** Gets or sets the title to use for the column. */
    title?: string | null;
};
