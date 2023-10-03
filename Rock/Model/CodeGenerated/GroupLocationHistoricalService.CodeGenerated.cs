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

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// GroupLocationHistorical Service class
    /// </summary>
    public partial class GroupLocationHistoricalService : Service<GroupLocationHistorical>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupLocationHistoricalService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GroupLocationHistoricalService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( GroupLocationHistorical item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GroupLocationHistoricalExtensionMethods
    {
        /// <summary>
        /// Clones this GroupLocationHistorical object to a new GroupLocationHistorical object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GroupLocationHistorical Clone( this GroupLocationHistorical source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GroupLocationHistorical;
            }
            else
            {
                var target = new GroupLocationHistorical();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this GroupLocationHistorical object to a new GroupLocationHistorical object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static GroupLocationHistorical CloneWithoutIdentity( this GroupLocationHistorical source )
        {
            var target = new GroupLocationHistorical();
            target.CopyPropertiesFrom( source );

            target.Id = 0;
            target.Guid = Guid.NewGuid();
            target.ForeignKey = null;
            target.ForeignId = null;
            target.ForeignGuid = null;
            target.CreatedByPersonAliasId = null;
            target.CreatedDateTime = RockDateTime.Now;
            target.ModifiedByPersonAliasId = null;
            target.ModifiedDateTime = RockDateTime.Now;

            return target;
        }

        /// <summary>
        /// Copies the properties from another GroupLocationHistorical object to this GroupLocationHistorical object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GroupLocationHistorical target, GroupLocationHistorical source )
        {
            target.Id = source.Id;
            target.CurrentRowIndicator = source.CurrentRowIndicator;
            target.EffectiveDateTime = source.EffectiveDateTime;
            target.ExpireDateTime = source.ExpireDateTime;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.GroupId = source.GroupId;
            target.GroupLocationId = source.GroupLocationId;
            target.GroupLocationTypeName = source.GroupLocationTypeName;
            target.GroupLocationTypeValueId = source.GroupLocationTypeValueId;
            target.LocationId = source.LocationId;
            target.LocationModifiedDateTime = source.LocationModifiedDateTime;
            target.LocationName = source.LocationName;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
