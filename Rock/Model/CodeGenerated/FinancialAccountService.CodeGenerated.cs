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
    /// FinancialAccount Service class
    /// </summary>
    public partial class FinancialAccountService : Service<FinancialAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccountService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public FinancialAccountService(RockContext context) : base(context)
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
        public bool CanDelete( FinancialAccount item, out string errorMessage )
        {
            errorMessage = string.Empty;

            if ( new Service<FinancialAccount>( Context ).Queryable().Any( a => a.ParentAccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, FinancialAccount.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialPledge>( Context ).Queryable().Any( a => a.AccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, FinancialPledge.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialScheduledTransactionDetail>( Context ).Queryable().Any( a => a.AccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, FinancialScheduledTransactionDetail.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialTransactionAlertType>( Context ).Queryable().Any( a => a.FinancialAccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, FinancialTransactionAlertType.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialTransactionDetail>( Context ).Queryable().Any( a => a.AccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, FinancialTransactionDetail.FriendlyTypeName );
                return false;
            }

            if ( new Service<Person>( Context ).Queryable().Any( a => a.ContributionFinancialAccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, Person.FriendlyTypeName );
                return false;
            }

            if ( new Service<RegistrationInstance>( Context ).Queryable().Any( a => a.AccountId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialAccount.FriendlyTypeName, RegistrationInstance.FriendlyTypeName );
                return false;
            }
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class FinancialAccountExtensionMethods
    {
        /// <summary>
        /// Clones this FinancialAccount object to a new FinancialAccount object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static FinancialAccount Clone( this FinancialAccount source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as FinancialAccount;
            }
            else
            {
                var target = new FinancialAccount();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this FinancialAccount object to a new FinancialAccount object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static FinancialAccount CloneWithoutIdentity( this FinancialAccount source )
        {
            var target = new FinancialAccount();
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
        /// Copies the properties from another FinancialAccount object to this FinancialAccount object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this FinancialAccount target, FinancialAccount source )
        {
            target.Id = source.Id;
            target.AccountTypeValueId = source.AccountTypeValueId;
            target.CampusId = source.CampusId;
            target.Description = source.Description;
            target.EndDate = source.EndDate;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.GlCode = source.GlCode;
            target.ImageBinaryFileId = source.ImageBinaryFileId;
            target.IsActive = source.IsActive;
            target.IsPublic = source.IsPublic;
            target.IsTaxDeductible = source.IsTaxDeductible;
            target.Name = source.Name;
            target.Order = source.Order;
            target.ParentAccountId = source.ParentAccountId;
            target.PublicDescription = source.PublicDescription;
            target.PublicName = source.PublicName;
            target.StartDate = source.StartDate;
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
