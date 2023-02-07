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

/** SignatureDocumentTemplate View Model */
export type SignatureDocumentTemplateBag = {
    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the binary file type identifier. */
    binaryFileTypeId?: number | null;

    /** The System Communication that will be used when sending the signature document completion email. */
    completionSystemCommunicationId?: number | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets a user defined description or summary about the SignatureDocumentTemplate. */
    description?: string | null;

    /** The term used to simply describe the document (wavier, release form, etc.). */
    documentTerm?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets the invite system email identifier. */
    inviteSystemCommunicationId?: number | null;

    /** Gets or sets a flag indicating if this item is active or not. */
    isActive: boolean;

    /** The Lava template that will be used to build the signature document. */
    lavaTemplate?: string | null;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the friendly Name of the SignatureDocumentTemplate. This property is required. */
    name?: string | null;

    /** Gets or sets the provider entity type identifier. */
    providerEntityTypeId?: number | null;

    /** Gets or sets the provider template key. */
    providerTemplateKey?: string | null;

    /**
     * This is used to define which kind of signature is being collected from the individual.
     * Ex: Rock.Model.SignatureType.Drawn or Rock.Model.SignatureType.Typed, etc.
     */
    signatureType: number;
};
