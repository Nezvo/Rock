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
using Rock.ViewModels;
using Rock.ViewModels.Entities;
using Rock.Web.Cache;

namespace Rock.Model
{
    /// <summary>
    /// Person Service class
    /// </summary>
    public partial class PersonService : Service<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public PersonService(RockContext context) : base(context)
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
        public bool CanDelete( Person item, out string errorMessage )
        {
            errorMessage = string.Empty;

            if ( new Service<AttributeValue>( Context ).Queryable().Any( a => a.ValueAsPersonId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Person.FriendlyTypeName, AttributeValue.FriendlyTypeName );
                return false;
            }

            if ( new Service<PersonAlias>( Context ).Queryable().Any( a => a.PersonId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Person.FriendlyTypeName, PersonAlias.FriendlyTypeName );
                return false;
            }
            return true;
        }
    }

    /// <summary>
    /// Person View Model Helper
    /// </summary>
    [DefaultViewModelHelper( typeof( Person ) )]
    public partial class PersonViewModelHelper : ViewModelHelper<Person, PersonBag>
    {
        /// <summary>
        /// Converts the model to a view model.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson">The current person.</param>
        /// <param name="loadAttributes">if set to <c>true</c> [load attributes].</param>
        /// <returns></returns>
        public override PersonBag CreateViewModel( Person model, Person currentPerson = null, bool loadAttributes = true )
        {
            if ( model == null )
            {
                return default;
            }

            var viewModel = new PersonBag
            {
                IdKey = model.IdKey,
                AccountProtectionProfile = ( int ) model.AccountProtectionProfile,
                AgeClassification = ( int ) model.AgeClassification,
                AnniversaryDate = model.AnniversaryDate,
                BirthDateKey = model.BirthDateKey,
                BirthDay = model.BirthDay,
                BirthMonth = model.BirthMonth,
                BirthYear = model.BirthYear,
                CommunicationPreference = ( int ) model.CommunicationPreference,
                ConnectionStatusValueId = model.ConnectionStatusValueId,
                ContributionFinancialAccountId = model.ContributionFinancialAccountId,
                DeceasedDate = model.DeceasedDate,
                Email = model.Email,
                EmailNote = model.EmailNote,
                EmailPreference = ( int ) model.EmailPreference,
                EthnicityValueId = model.EthnicityValueId,
                FirstName = model.FirstName,
                Gender = ( int ) model.Gender,
                GivingGroupId = model.GivingGroupId,
                GivingLeaderId = model.GivingLeaderId,
                GraduationYear = model.GraduationYear,
                InactiveReasonNote = model.InactiveReasonNote,
                IsDeceased = model.IsDeceased,
                IsEmailActive = model.IsEmailActive,
                IsLockedAsChild = model.IsLockedAsChild,
                IsSystem = model.IsSystem,
                LastName = model.LastName,
                MaritalStatusValueId = model.MaritalStatusValueId,
                MiddleName = model.MiddleName,
                NickName = model.NickName,
                PhotoId = model.PhotoId,
                PreferredLanguageValueId = model.PreferredLanguageValueId,
                PrimaryCampusId = model.PrimaryCampusId,
                PrimaryFamilyId = model.PrimaryFamilyId,
                RaceValueId = model.RaceValueId,
                RecordStatusLastModifiedDateTime = model.RecordStatusLastModifiedDateTime,
                RecordStatusReasonValueId = model.RecordStatusReasonValueId,
                RecordStatusValueId = model.RecordStatusValueId,
                RecordTypeValueId = model.RecordTypeValueId,
                ReminderCount = model.ReminderCount,
                ReviewReasonNote = model.ReviewReasonNote,
                ReviewReasonValueId = model.ReviewReasonValueId,
                SuffixValueId = model.SuffixValueId,
                SystemNote = model.SystemNote,
                TitleValueId = model.TitleValueId,
                TopSignalColor = model.TopSignalColor,
                TopSignalIconCssClass = model.TopSignalIconCssClass,
                TopSignalId = model.TopSignalId,
                ViewedCount = model.ViewedCount,
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
    public static partial class PersonExtensionMethods
    {
        /// <summary>
        /// Clones this Person object to a new Person object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static Person Clone( this Person source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as Person;
            }
            else
            {
                var target = new Person();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this Person object to a new Person object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static Person CloneWithoutIdentity( this Person source )
        {
            var target = new Person();
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
        /// Copies the properties from another Person object to this Person object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this Person target, Person source )
        {
            target.Id = source.Id;
            target.AccountProtectionProfile = source.AccountProtectionProfile;
            target.AgeClassification = source.AgeClassification;
            target.AnniversaryDate = source.AnniversaryDate;
            target.BirthDateKey = source.BirthDateKey;
            target.BirthDay = source.BirthDay;
            target.BirthMonth = source.BirthMonth;
            target.BirthYear = source.BirthYear;
            target.CommunicationPreference = source.CommunicationPreference;
            target.ConnectionStatusValueId = source.ConnectionStatusValueId;
            target.ContributionFinancialAccountId = source.ContributionFinancialAccountId;
            target.DeceasedDate = source.DeceasedDate;
            target.Email = source.Email;
            target.EmailNote = source.EmailNote;
            target.EmailPreference = source.EmailPreference;
            target.EthnicityValueId = source.EthnicityValueId;
            target.FirstName = source.FirstName;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.Gender = source.Gender;
            target.GivingGroupId = source.GivingGroupId;
            target.GivingLeaderId = source.GivingLeaderId;
            target.GraduationYear = source.GraduationYear;
            target.InactiveReasonNote = source.InactiveReasonNote;
            target.IsDeceased = source.IsDeceased;
            target.IsEmailActive = source.IsEmailActive;
            target.IsLockedAsChild = source.IsLockedAsChild;
            target.IsSystem = source.IsSystem;
            target.LastName = source.LastName;
            target.MaritalStatusValueId = source.MaritalStatusValueId;
            target.MiddleName = source.MiddleName;
            target.NickName = source.NickName;
            target.PhotoId = source.PhotoId;
            target.PreferredLanguageValueId = source.PreferredLanguageValueId;
            target.PrimaryCampusId = source.PrimaryCampusId;
            target.PrimaryFamilyId = source.PrimaryFamilyId;
            target.RaceValueId = source.RaceValueId;
            target.RecordStatusLastModifiedDateTime = source.RecordStatusLastModifiedDateTime;
            target.RecordStatusReasonValueId = source.RecordStatusReasonValueId;
            target.RecordStatusValueId = source.RecordStatusValueId;
            target.RecordTypeValueId = source.RecordTypeValueId;
            target.ReminderCount = source.ReminderCount;
            target.ReviewReasonNote = source.ReviewReasonNote;
            target.ReviewReasonValueId = source.ReviewReasonValueId;
            target.SuffixValueId = source.SuffixValueId;
            target.SystemNote = source.SystemNote;
            target.TitleValueId = source.TitleValueId;
            target.TopSignalColor = source.TopSignalColor;
            target.TopSignalIconCssClass = source.TopSignalIconCssClass;
            target.TopSignalId = source.TopSignalId;
            target.ViewedCount = source.ViewedCount;
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
        public static PersonBag ToViewModel( this Person model, Person currentPerson = null, bool loadAttributes = false )
        {
            var helper = new PersonViewModelHelper();
            var viewModel = helper.CreateViewModel( model, currentPerson, loadAttributes );
            return viewModel;
        }

    }

}
