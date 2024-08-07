﻿// <copyright>
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

using Rock.Model;

namespace Rock.Attribute
{
    /// <summary>
    /// Field Attribute to select a <see cref="CommunicationTemplate" />. Stored as the CommunicationTemplate's Guid.
    /// </summary>
    [AttributeUsage( AttributeTargets.Class, AllowMultiple = true, Inherited = true )]
    public class CommunicationTemplateFieldAttribute : FieldAttribute
    {
        private const string INCLUDE_INACTIVE_KEY = "includeInactive";

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationTemplateFieldAttribute" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        /// <param name="defaultTemplateGuid">The default template unique identifier.</param>
        /// <param name="category">The category.</param>
        /// <param name="order">The order.</param>
        /// <param name="key">The key.</param>
        public CommunicationTemplateFieldAttribute( string name, string description = "", bool required = true, string defaultTemplateGuid = "", string category = "", int order = 0, string key = null )
            : base( name, description, required, defaultTemplateGuid, category, order, key, typeof( Rock.Field.Types.CommunicationTemplateFieldType ).FullName )
        {
            IncludeInactive = false;
        }

        /// <summary>
        /// Gets or sets a value indicating if inactive items will be included.
        /// </summary>
        /// <value>
        ///   <c>true</c> if inactive items will be included; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeInactive
        {
            get
            {
                return FieldConfigurationValues.GetValueOrNull( INCLUDE_INACTIVE_KEY ).AsBoolean();
            }

            set
            {
                FieldConfigurationValues.AddOrReplace( INCLUDE_INACTIVE_KEY, new Field.ConfigurationValue( value.ToString() ) );
            }
        }
    }
}