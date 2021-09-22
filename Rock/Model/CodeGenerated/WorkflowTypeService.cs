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

using Rock.Attribute;
using Rock.Data;
using Rock.ViewModel;
using Rock.Web.Cache;

namespace Rock.Model
{
    /// <summary>
    /// WorkflowType Service class
    /// </summary>
    public partial class WorkflowTypeService : Service<WorkflowType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTypeService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public WorkflowTypeService(RockContext context) : base(context)
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
        public bool CanDelete( WorkflowType item, out string errorMessage )
        {
            errorMessage = string.Empty;

            if ( new Service<AchievementType>( Context ).Queryable().Any( a => a.AchievementFailureWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, AchievementType.FriendlyTypeName );
                return false;
            }

            if ( new Service<AchievementType>( Context ).Queryable().Any( a => a.AchievementStartWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, AchievementType.FriendlyTypeName );
                return false;
            }

            if ( new Service<AchievementType>( Context ).Queryable().Any( a => a.AchievementSuccessWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, AchievementType.FriendlyTypeName );
                return false;
            }

            if ( new Service<FinancialTransactionAlertType>( Context ).Queryable().Any( a => a.WorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, FinancialTransactionAlertType.FriendlyTypeName );
                return false;
            }

            if ( new Service<GroupType>( Context ).Queryable().Any( a => a.ScheduleCancellationWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, GroupType.FriendlyTypeName );
                return false;
            }

            if ( new Service<MediaFolder>( Context ).Queryable().Any( a => a.WorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, MediaFolder.FriendlyTypeName );
                return false;
            }

            if ( new Service<RegistrationInstance>( Context ).Queryable().Any( a => a.RegistrationWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, RegistrationInstance.FriendlyTypeName );
                return false;
            }

            if ( new Service<RegistrationTemplate>( Context ).Queryable().Any( a => a.RegistrantWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, RegistrationTemplate.FriendlyTypeName );
                return false;
            }

            if ( new Service<RegistrationTemplate>( Context ).Queryable().Any( a => a.RegistrationWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, RegistrationTemplate.FriendlyTypeName );
                return false;
            }

            if ( new Service<StepWorkflowTrigger>( Context ).Queryable().Any( a => a.WorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, StepWorkflowTrigger.FriendlyTypeName );
                return false;
            }
            return true;
        }
    }

    /// <summary>
    /// WorkflowType View Model Helper
    /// </summary>
    [DefaultViewModelHelper( typeof( WorkflowType ) )]
    public partial class WorkflowTypeViewModelHelper : ViewModelHelper<WorkflowType, Rock.ViewModel.WorkflowTypeViewModel>
    {
        /// <summary>
        /// Converts the model to a view model.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson">The current person.</param>
        /// <param name="loadAttributes">if set to <c>true</c> [load attributes].</param>
        /// <returns></returns>
        public override Rock.ViewModel.WorkflowTypeViewModel CreateViewModel( WorkflowType model, Person currentPerson = null, bool loadAttributes = true )
        {
            if ( model == null )
            {
                return default;
            }

            var viewModel = new Rock.ViewModel.WorkflowTypeViewModel
            {
                Id = model.Id,
                Guid = model.Guid,
                CategoryId = model.CategoryId,
                CompletedWorkflowRetentionPeriod = model.CompletedWorkflowRetentionPeriod,
                Description = model.Description,
                IconCssClass = model.IconCssClass,
                IsActive = model.IsActive,
                IsPersisted = model.IsPersisted,
                IsSystem = model.IsSystem,
                LoggingLevel = ( int ) model.LoggingLevel,
                LogRetentionPeriod = model.LogRetentionPeriod,
                Name = model.Name,
                NoActionMessage = model.NoActionMessage,
                Order = model.Order,
                ProcessingIntervalSeconds = model.ProcessingIntervalSeconds,
                SummaryViewText = model.SummaryViewText,
                WorkflowIdPrefix = model.WorkflowIdPrefix,
                WorkTerm = model.WorkTerm,
                CreatedDateTime = model.CreatedDateTime,
                ModifiedDateTime = model.ModifiedDateTime,
                CreatedByPersonAliasId = model.CreatedByPersonAliasId,
                ModifiedByPersonAliasId = model.ModifiedByPersonAliasId,
            };

            AddAttributesToViewModel( model, viewModel, currentPerson, loadAttributes );
            ApplyAdditionalPropertiesAndSecurityToViewModel( model, viewModel, currentPerson, loadAttributes );
            return viewModel;
        }
    }


    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class WorkflowTypeExtensionMethods
    {
        /// <summary>
        /// Clones this WorkflowType object to a new WorkflowType object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static WorkflowType Clone( this WorkflowType source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as WorkflowType;
            }
            else
            {
                var target = new WorkflowType();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this WorkflowType object to a new WorkflowType object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static WorkflowType CloneWithoutIdentity( this WorkflowType source )
        {
            var target = new WorkflowType();
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
        /// Copies the properties from another WorkflowType object to this WorkflowType object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this WorkflowType target, WorkflowType source )
        {
            target.Id = source.Id;
            target.CategoryId = source.CategoryId;
            target.CompletedWorkflowRetentionPeriod = source.CompletedWorkflowRetentionPeriod;
            target.Description = source.Description;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IconCssClass = source.IconCssClass;
            target.IsActive = source.IsActive;
            target.IsPersisted = source.IsPersisted;
            target.IsSystem = source.IsSystem;
            target.LoggingLevel = source.LoggingLevel;
            target.LogRetentionPeriod = source.LogRetentionPeriod;
            target.Name = source.Name;
            target.NoActionMessage = source.NoActionMessage;
            target.Order = source.Order;
            target.ProcessingIntervalSeconds = source.ProcessingIntervalSeconds;
            target.SummaryViewText = source.SummaryViewText;
            target.WorkflowIdPrefix = source.WorkflowIdPrefix;
            target.WorkTerm = source.WorkTerm;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }

        /// <summary>
        /// Creates a view model from this entity
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson" >The currentPerson.</param>
        /// <param name="loadAttributes" >Load attributes?</param>
        public static Rock.ViewModel.WorkflowTypeViewModel ToViewModel( this WorkflowType model, Person currentPerson = null, bool loadAttributes = false )
        {
            var helper = new WorkflowTypeViewModelHelper();
            var viewModel = helper.CreateViewModel( model, currentPerson, loadAttributes );
            return viewModel;
        }

    }

}
