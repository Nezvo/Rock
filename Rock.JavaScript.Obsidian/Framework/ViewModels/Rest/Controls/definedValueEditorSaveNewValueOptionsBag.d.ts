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
 * The options that can be passed to the SaveNewValue API action of
 * the DefinedValuePicker control for adding a new Defined Value
 */
export type DefinedValueEditorSaveNewValueOptionsBag = {
    /** A collection of attribute values for the new defined value */
    attributeValues?: Record<string, string> | null;

    /** The GUID of the defined type of the value we're saving */
    definedTypeGuid: Guid;

    /** The description property of the new defined value */
    description?: string | null;

    /** Gets or sets the security grant token to use when performing authorization checks. */
    securityGrantToken?: string | null;

    /**
     * Gets or sets the attribute identifier that should be updated. This
     * must be null or represent a Defined Value field type attribute.
     */
    updateAttributeGuid?: Guid | null;

    /** The value property of the new defined value */
    value?: string | null;
};
