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

using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using Rock.Data;
using Rock.Model;
using Rock.Web.Cache;

namespace Rock.Reporting.DataTransform.Person
{
    /// <summary>
    /// Person Head of Household Transformation
    /// </summary>
    [Description( "Transform result to Head of Household" )]
    [Export( typeof( DataTransformComponent ) )]
    [ExportMetadata( "ComponentName", "Person Head of Household Transformation" )]
    public class HeadOfHouseholdTransform : DataTransformComponent<Rock.Model.Person>
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public override string Title
        {
            get { return "Head of Household"; }
        }

        /// <summary>
        /// Gets the name of the transformed entity type.
        /// </summary>
        /// <value>
        /// The name of the transformed entity type.
        /// </value>
        public override string TransformedEntityTypeName
        {
            get { return "Rock.Model.Person"; }
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        /// <param name="serviceInstance">The service instance.</param>
        /// <param name="parameterExpression">The parameter expression.</param>
        /// <param name="whereExpression">The where expression.</param>
        /// <returns></returns>
        public override Expression GetExpression( IService serviceInstance, ParameterExpression parameterExpression, Expression whereExpression )
        {
            IQueryable<int> idQuery = serviceInstance.GetIds( parameterExpression, whereExpression );
            return BuildExpression( serviceInstance, idQuery, parameterExpression );
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        /// <param name="serviceInstance">The service instance.</param>
        /// <param name="personQueryable">The person queryable.</param>
        /// <param name="parameterExpression">The parameter expression.</param>
        /// <returns></returns>
        public override Expression GetExpression( IService serviceInstance, IQueryable<Rock.Model.Person> personQueryable, ParameterExpression parameterExpression )
        {
            return BuildExpression( serviceInstance, personQueryable.Select( p => p.Id ), parameterExpression );
        }

        /// <summary>
        /// Builds the expression.
        /// </summary>
        /// <param name="serviceInstance">The service instance.</param>
        /// <param name="idQuery">The id query.</param>
        /// <param name="parameterExpression">The parameter expression.</param>
        /// <returns></returns>
        private Expression BuildExpression( IService serviceInstance, IQueryable<int> idQuery, ParameterExpression parameterExpression )
        {
            var familyGroupType = GroupTypeCache.GetFamilyGroupType();
            int adultRoleId = GroupTypeCache.GetFamilyGroupType().Roles.Where( a => a.Guid == Rock.SystemGuid.GroupRole.GROUPROLE_FAMILY_MEMBER_ADULT.AsGuid() ).Select( a => a.Id ).FirstOrDefault();
            int childRoleId = GroupTypeCache.GetFamilyGroupType().Roles.Where( a => a.Guid == Rock.SystemGuid.GroupRole.GROUPROLE_FAMILY_MEMBER_CHILD.AsGuid() ).Select( a => a.Id ).FirstOrDefault();

            var headOfHouseholdQry = new GroupService( ( RockContext ) serviceInstance.Context ).Queryable()
                    .Where( gm => gm.GroupTypeId == familyGroupType.Id && gm.Members.Any( m => idQuery.Contains( m.PersonId ) ) )
                    .SelectMany( f => f.Members.Where( a => !a.Person.IsDeceased ) )
                    .GroupBy( m =>
                        m.GroupId,
                        ( key, g ) => g
                    .OrderBy( m => m.GroupRole.Order )
                    .ThenBy( m => m.Person.Gender )
                    .ThenBy( m => m.Person.BirthYear )
                    .ThenBy( m => m.Person.BirthMonth )
                    .ThenBy( m => m.Person.BirthDay )
                    .FirstOrDefault() )
                    .Select( m => m.PersonId );

            var qry = new PersonService( ( RockContext ) serviceInstance.Context ).Queryable()
                .Where( p => headOfHouseholdQry.Contains( p.Id ) );

            return FilterExpressionExtractor.Extract<Rock.Model.Person>( qry, parameterExpression, "p" );
        }
    }
}