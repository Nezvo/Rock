﻿//------------------------------------------------------------------------------
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
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for Page that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class PageEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        // Made Obsolete in Rock "1.16"
        [Obsolete( "Use AdditionalSettingsJson instead.", false )]
        public string AdditionalSettings { get; set; }

        /// <summary />
        public string AdditionalSettingsJson { get; set; }

        /// <summary />
        public bool AllowIndexing { get; set; } = true;

        /// <summary />
        public string BodyCssClass { get; set; }

        /// <summary />
        public Rock.Client.Enums.Cms.BotGuardianLevel BotGuardianLevel { get; set; } = Rock.Client.Enums.Cms.BotGuardianLevel.Inherit;

        /// <summary />
        public bool BreadCrumbDisplayIcon { get; set; }

        /// <summary />
        public bool BreadCrumbDisplayName { get; set; } = true;

        /// <summary />
        public string BrowserTitle { get; set; }

        /// <summary />
        public string CacheControlHeaderSettings { get; set; }

        /// <summary />
        public string Description { get; set; }

        /// <summary />
        public Rock.Client.Enums.DisplayInNavWhen DisplayInNavWhen { get; set; }

        /// <summary />
        public bool EnableViewState { get; set; } = true;

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string HeaderContent { get; set; }

        /// <summary />
        public int? IconBinaryFileId { get; set; }

        /// <summary />
        public string IconCssClass { get; set; }

        /// <summary />
        public bool IncludeAdminFooter { get; set; } = true;

        /// <summary />
        public string InternalName { get; set; }

        /// <summary />
        public bool IsSystem { get; set; }

        /// <summary />
        public string KeyWords { get; set; }

        /// <summary />
        public int LayoutId { get; set; }

        /// <summary />
        public double? MedianPageLoadTimeDurationSeconds { get; set; }

        /// <summary />
        public bool MenuDisplayChildPages { get; set; } = true;

        /// <summary />
        public bool MenuDisplayDescription { get; set; }

        /// <summary />
        public bool MenuDisplayIcon { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public bool PageDisplayBreadCrumb { get; set; } = true;

        /// <summary />
        public bool PageDisplayDescription { get; set; } = true;

        /// <summary />
        public bool PageDisplayIcon { get; set; } = true;

        /// <summary />
        public bool PageDisplayTitle { get; set; } = true;

        /// <summary />
        public string PageTitle { get; set; }

        /// <summary />
        public int? ParentPageId { get; set; }

        /// <summary />
        public int? RateLimitPeriod { get; set; }

        /// <summary />
        public int? RateLimitRequestPerPeriod { get; set; }

        /// <summary />
        public bool RequiresEncryption { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// This does not need to be set or changed. Rock will always set this to the current date/time when saved to the database.
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source Page object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( Page source )
        {
            this.Id = source.Id;
            #pragma warning disable 612, 618
            this.AdditionalSettings = source.AdditionalSettings;
            #pragma warning restore 612, 618
            this.AdditionalSettingsJson = source.AdditionalSettingsJson;
            this.AllowIndexing = source.AllowIndexing;
            this.BodyCssClass = source.BodyCssClass;
            this.BotGuardianLevel = source.BotGuardianLevel;
            this.BreadCrumbDisplayIcon = source.BreadCrumbDisplayIcon;
            this.BreadCrumbDisplayName = source.BreadCrumbDisplayName;
            this.BrowserTitle = source.BrowserTitle;
            this.CacheControlHeaderSettings = source.CacheControlHeaderSettings;
            this.Description = source.Description;
            this.DisplayInNavWhen = source.DisplayInNavWhen;
            this.EnableViewState = source.EnableViewState;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.HeaderContent = source.HeaderContent;
            this.IconBinaryFileId = source.IconBinaryFileId;
            this.IconCssClass = source.IconCssClass;
            this.IncludeAdminFooter = source.IncludeAdminFooter;
            this.InternalName = source.InternalName;
            this.IsSystem = source.IsSystem;
            this.KeyWords = source.KeyWords;
            this.LayoutId = source.LayoutId;
            this.MedianPageLoadTimeDurationSeconds = source.MedianPageLoadTimeDurationSeconds;
            this.MenuDisplayChildPages = source.MenuDisplayChildPages;
            this.MenuDisplayDescription = source.MenuDisplayDescription;
            this.MenuDisplayIcon = source.MenuDisplayIcon;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.Order = source.Order;
            this.PageDisplayBreadCrumb = source.PageDisplayBreadCrumb;
            this.PageDisplayDescription = source.PageDisplayDescription;
            this.PageDisplayIcon = source.PageDisplayIcon;
            this.PageDisplayTitle = source.PageDisplayTitle;
            this.PageTitle = source.PageTitle;
            this.ParentPageId = source.ParentPageId;
            this.RateLimitPeriod = source.RateLimitPeriod;
            this.RateLimitRequestPerPeriod = source.RateLimitRequestPerPeriod;
            this.RequiresEncryption = source.RequiresEncryption;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for Page that includes all the fields that are available for GETs. Use this for GETs (use PageEntity for POST/PUTs)
    /// </summary>
    public partial class Page : PageEntity
    {
        /// <summary />
        public ICollection<Block> Blocks { get; set; }

        /// <summary />
        public ICollection<PageContext> PageContexts { get; set; }

        /// <summary />
        public ICollection<PageRoute> PageRoutes { get; set; }

        /// <summary />
        public ICollection<Page> Pages { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
