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

/**
 * Describes a field type configuration state. This provides the information
 * required to edit a field type on a remote system.
 */
export type FieldTypeEditorUpdateAttributeConfigurationResultBag = {
    /**
     * Gets or sets the configuration options that describe the current
     * selections when editing a field type.
     */
    adminConfigurationValues?: Record<string, string> | null;

    /**
     * Gets or sets the configuration properties that contain information
     * describing a field type edit operation.
     */
    configurationProperties?: Record<string, string> | null;

    /**
     * Gets or sets the default attribute value view model that corresponds
     * to the current Rock.ViewModels.Controls.FieldTypeEditorUpdateAttributeConfigurationResultBag.EditConfigurationValues.
     */
    defaultValue?: string | null;

    /**
     * Gets or sets the configuration values that describe the field
     * when it is in edit mode (such as the default control).
     */
    editConfigurationValues?: Record<string, string> | null;
};
