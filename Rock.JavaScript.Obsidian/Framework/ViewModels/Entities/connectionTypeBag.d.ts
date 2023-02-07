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

/** ConnectionType View Model */
export type ConnectionTypeBag = {
    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the connection request detail Rock.Model.Page identifier. */
    connectionRequestDetailPageId?: number | null;

    /** Gets or sets the connection request detail Rock.Model.PageRoute identifier. */
    connectionRequestDetailPageRouteId?: number | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets the number of days until the request is considered idle. */
    daysUntilRequestIdle: number;

    /** Gets or sets the default view mode (list or board). */
    defaultView: number;

    /** Gets or sets the description. */
    description?: string | null;

    /** Gets or sets a value indicating whether full activity lists are enabled. */
    enableFullActivityList: boolean;

    /** Gets or sets a value indicating whether future follow-ups are enabled. */
    enableFutureFollowup: boolean;

    /** Gets or sets a value indicating whether [enable request security]. */
    enableRequestSecurity: boolean;

    /** Gets or sets the icon CSS class. */
    iconCssClass?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a value indicating whether this instance is active. */
    isActive: boolean;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the name. */
    name?: string | null;

    /** Gets or sets the order. */
    order: number;

    /** Gets or sets the owner Rock.Model.PersonAlias identifier. */
    ownerPersonAliasId?: number | null;

    /** Gets or sets the request badge lava. */
    requestBadgeLava?: string | null;

    /** Gets or sets the request header lava. */
    requestHeaderLava?: string | null;

    /** Gets or sets a value indicating whether this connection type requires a placement group to connect. */
    requiresPlacementGroupToConnect: boolean;
};
