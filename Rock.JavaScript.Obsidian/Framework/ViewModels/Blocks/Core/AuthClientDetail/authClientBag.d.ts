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

import { AuthClientScopeBag } from "@Obsidian/ViewModels/Blocks/Core/AuthClientDetail/authClientScopeBag";
import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

export type AuthClientBag = {
    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the client identifier. */
    clientId?: string | null;

    /** Gets or sets the client secret. */
    clientSecret?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a flag indicating if this item is active or not. */
    isActive: boolean;

    /** Gets or sets the name. */
    name?: string | null;

    /** Gets or sets the post logout redirect URI. */
    postLogoutRedirectUri?: string | null;

    /** Gets or sets the redirect URL. */
    redirectUri?: string | null;

    /** Gets or sets the scope approval expiration in days. */
    scopeApprovalExpiration: number;

    /** Gets or sets the available scope claims. */
    scopeClaims?: Record<string, AuthClientScopeBag[]> | null;
};
