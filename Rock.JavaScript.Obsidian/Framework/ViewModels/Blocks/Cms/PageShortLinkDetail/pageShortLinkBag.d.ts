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

export type PageShortLinkBag = {
    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the link to be copied to the clipboard in the UI when the user clicks the copy button in the view mode. */
    copyLink?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets the Rock.Model.Site that is associated with this PageShortLink. */
    site?: ListItemBag | null;

    /** Gets or sets the token. */
    token?: string | null;

    /** Gets or sets the URL. */
    url?: string | null;

    /** Gets or sets the DefinedValue of the UTM Campaign to be passed to the remote device. */
    utmCampaignValue?: ListItemBag | null;

    /** Gets or sets the Utm Content to be passed to the remote device. */
    utmContent?: string | null;

    /** Gets or sets the DefinedValue of the UTM Medium to be passed to the remote device. */
    utmMediumValue?: ListItemBag | null;

    /** Gets or sets the DefinedValue of the UTM Source to be passed to the remote device. */
    utmSourceValue?: ListItemBag | null;

    /** Gets or sets the Utm Term to be passed to the remote device. */
    utmTerm?: string | null;
};
