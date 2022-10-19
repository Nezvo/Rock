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

import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

/** GroupLocation View Model */
export type GroupLocationBag = {
    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets the Id of the Rock.Model.Group that is associated with this GroupLocation. This property is required. */
    groupId: number;

    /**
     * The Id of the GroupLocationType Rock.Model.DefinedValue that is used to identify the type of Rock.Model.GroupLocation
     * that this is. Examples: Home Address, Work Address, Primary Address.
     */
    groupLocationTypeValueId?: number | null;

    /**
     * Gets or sets the group member Rock.Model.PersonAlias identifier.  A GroupLocation can optionally be created by selecting one of the group 
     * member's locations.  If the GroupLocation is created this way, the member's person alias id is saved with the group location
     */
    groupMemberPersonAliasId?: number | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /**
     * Gets or sets a flag indicating if the Rock.Model.Location referenced by this GroupLocation is the mailing address/location for the Rock.Model.Group.  
     * This field is only supported in the UI for family groups
     */
    isMailingLocation: boolean;

    /**
     * Gets or sets a flag indicating if this is the mappable location for this 
     * This field is only supported in the UI for family groups
     */
    isMappedLocation: boolean;

    /** Gets or sets the Id of the Rock.Model.Location that is associated with this GroupLocation. This property is required. */
    locationId: number;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /**
     * Gets or sets the display order of the GroupLocation in the group location list. The lower the number the higher the 
     * display priority this GroupLocation has. This property is required.
     */
    order: number;
};
