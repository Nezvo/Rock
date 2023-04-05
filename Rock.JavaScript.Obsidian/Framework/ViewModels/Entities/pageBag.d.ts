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

/** Page View Model */
export type PageBag = {
    /** Gets or sets the additional settings. */
    additionalSettings?: string | null;

    /** Gets or sets a value indicating whether [allow indexing]. */
    allowIndexing: boolean;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the body CSS class. */
    bodyCssClass?: string | null;

    /** Gets or sets a value indicating whether icon is displayed in breadcrumb. */
    breadCrumbDisplayIcon: boolean;

    /** Gets or sets a value indicating whether the Page Name is displayed in the breadcrumb. */
    breadCrumbDisplayName: boolean;

    /** Gets or sets the browser title to use for the page. */
    browserTitle?: string | null;

    /** Gets or sets the cache control header settings. */
    cacheControlHeaderSettings?: string | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets a user defined description of the page.  This will be added as a meta tag for the page  */
    description?: string | null;

    /** Gets or sets a value indicating when the Page should be displayed in the navigation. */
    displayInNavWhen: number;

    /** Gets or sets a flag indicating if view state should be enabled on the page.  */
    enableViewState: boolean;

    /** Gets or sets HTML content to add to the page header area of the page when rendered. */
    headerContent?: string | null;

    /** Gets or sets the icon binary file identifier. */
    iconBinaryFileId?: number | null;

    /** Gets or sets the icon CSS class name for a font vector based icon. */
    iconCssClass?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a flag indicating if the admin footer should be displayed when a Site Administrator is logged in. */
    includeAdminFooter: boolean;

    /** Gets or sets the internal name to use when administering this page */
    internalName?: string | null;

    /** Gets or sets a flag indicating if the Page is part of the Rock core system/framework. */
    isSystem: boolean;

    /** Gets or sets the key words. */
    keyWords?: string | null;

    /** Gets or sets the Id of the Rock.Model.Layout that this Page uses. */
    layoutId: number;

    /**
     * Gets or sets the median page load time in seconds. Typically calculated from a set of
     * Rock.Model.Interaction.InteractionTimeToServe values.
     */
    medianPageLoadTimeDurationSeconds?: number | null;

    /** Gets or sets a flag indicating if the Page's children Pages should be displayed in the menu. */
    menuDisplayChildPages: boolean;

    /** Gets or sets a flag indicating if the Page description should be displayed in the menu. */
    menuDisplayDescription: boolean;

    /** Gets or sets a flag indicating if the Page icon should be displayed in the menu. */
    menuDisplayIcon: boolean;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /**
     * Gets or sets a number indicating the order of the page in the menu and in the site map.
     * This will also affect the page order in the menu. This property is required.
     */
    order: number;

    /** Gets or sets a flag indicating whether breadcrumbs are displayed on Page */
    pageDisplayBreadCrumb: boolean;

    /** Gets or sets a value indicating whether the Page description should be displayed on the page. */
    pageDisplayDescription: boolean;

    /** Gets or sets a value indicating whether the Page icon should be displayed on the Page. */
    pageDisplayIcon: boolean;

    /** Gets or sets a value indicating whether the Page Title should be displayed on the page (if the Rock.Model.Layout supports it). */
    pageDisplayTitle: boolean;

    /** Gets or sets the title of the of the Page to use as the page caption, in menu's, breadcrumb display etc. */
    pageTitle?: string | null;

    /** Gets or sets the Id of the parent Page. */
    parentPageId?: number | null;

    /** Gets or sets the rate limit period. */
    rateLimitPeriod?: number | null;

    /** Gets or sets the rate limit request per period. */
    rateLimitRequestPerPeriod?: number | null;

    /** Gets or sets a flag that indicates if the Page requires SSL encryption. */
    requiresEncryption: boolean;
};
