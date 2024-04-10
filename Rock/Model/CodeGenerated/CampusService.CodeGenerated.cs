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
    /// Campus Service class
    /// </summary>
    public partial class CampusService : Service<Campus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampusService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public CampusService(RockContext context) : base(context)
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
        public bool CanDelete( Campus item, out string errorMessage )
        {
            errorMessage = string.Empty;

            if ( new Service<BenevolenceRequest>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, BenevolenceRequest.FriendlyTypeName );
                return false;
            }

            if ( new Service<ConnectionRequest>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, ConnectionRequest.FriendlyTypeName );
                return false;
            }

            if ( new Service<EventItemOccurrence>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, EventItemOccurrence.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialAccount>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, FinancialAccount.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialBatch>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, FinancialBatch.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialTransactionAlertType>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, FinancialTransactionAlertType.FriendlyTypeName );
                return false;
            }

            if ( new Service<Group>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, Group.FriendlyTypeName );
                return false;
            }

            if ( new Service<GroupHistorical>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, GroupHistorical.FriendlyTypeName );
                return false;
            }

            if ( new Service<InteractiveExperienceAnswer>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, InteractiveExperienceAnswer.FriendlyTypeName );
                return false;
            }

            if ( new Service<InteractiveExperienceOccurrence>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, InteractiveExperienceOccurrence.FriendlyTypeName );
                return false;
            }

            if ( new Service<InteractiveExperienceScheduleCampus>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, InteractiveExperienceScheduleCampus.FriendlyTypeName );
                return false;
            }

            if ( new Service<LearningProgramCompletion>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, LearningProgramCompletion.FriendlyTypeName );
                return false;
            }

            if ( new Service<Person>( Context ).Queryable().Any( a => a.PrimaryCampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, Person.FriendlyTypeName );
                return false;
            }

            if ( new Service<Step>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, Step.FriendlyTypeName );
                return false;
            }

            if ( new Service<StepProgramCompletion>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, StepProgramCompletion.FriendlyTypeName );
                return false;
            }

            if ( new Service<Workflow>( Context ).Queryable().Any( a => a.CampusId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Campus.FriendlyTypeName, Workflow.FriendlyTypeName );
                return false;
            }
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class CampusExtensionMethods
    {
        /// <summary>
        /// Clones this Campus object to a new Campus object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static Campus Clone( this Campus source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as Campus;
            }
            else
            {
                var target = new Campus();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this Campus object to a new Campus object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static Campus CloneWithoutIdentity( this Campus source )
        {
            var target = new Campus();
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
        /// Copies the properties from another Campus object to this Campus object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this Campus target, Campus source )
        {
            target.Id = source.Id;
            target.CampusStatusValueId = source.CampusStatusValueId;
            target.CampusTypeValueId = source.CampusTypeValueId;
            target.Description = source.Description;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IsActive = source.IsActive;
            target.IsSystem = source.IsSystem;
            target.LeaderPersonAliasId = source.LeaderPersonAliasId;
            target.LocationId = source.LocationId;
            target.Name = source.Name;
            target.Order = source.Order;
            target.PhoneNumber = source.PhoneNumber;
            target.ServiceTimes = source.ServiceTimes;
            target.ShortCode = source.ShortCode;
            target.TeamGroupId = source.TeamGroupId;
            target.TimeZoneId = source.TimeZoneId;
            target.Url = source.Url;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
