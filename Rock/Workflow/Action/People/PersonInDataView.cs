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
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

using Rock;
using Rock.Attribute;
using Rock.Data;
using Rock.Model;
using Rock.Web.Cache;

namespace Rock.Workflow.Action
{
    /// <summary>
    /// Sets a workflow attribute True or False depending on if the person is in selected Data View.
    /// </summary>
    [ActionCategory( "People" )]
    [Description( "Sets a workflow attribute True or False depending on if the person is in selected Data View." )]
    [Export( typeof( ActionComponent ) )]
    [ExportMetadata( "ComponentName", "Person In Data View" )]

    [WorkflowAttribute( "Person", "Workflow attribute that contains the person to find in the selected Data View.", true, "", "", 0, null, new string[] { "Rock.Field.Types.PersonFieldType" } )]
    [DataViewField( "DataView", "DataView to check.", true, "", "Rock.Model.Person", order: 1 )]
    [IntegerField( "Timeout", "Number of seconds to wait before timing out.", false, 30, order: 2 )]
    [WorkflowAttribute( "Boolean", "Workflow attribute to set True or False.", true, "", "", 3, null, new string[] { "Rock.Field.Types.BooleanFieldType" } )]

    [Rock.SystemGuid.EntityTypeGuid( "B6E3DA81-FDA9-4579-9438-93D6DCB86DAB")]
    public class PersonInDataView : ActionComponent
    {
        /// <summary>
        /// Executes the specified workflow.
        /// </summary>
        /// <param name="rockContext">The rock context.</param>
        /// <param name="action">The action.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns></returns>
        public override bool Execute( RockContext rockContext, WorkflowAction action, Object entity, out List<string> errorMessages )
        {
            errorMessages = new List<string>();

            var person = GetPersonAliasFromActionAttribute( "Person", rockContext, action, errorMessages );
            if ( person != null )
            {
                Guid booleanGuid = GetAttributeValue( action, "Boolean" ).AsGuid();
                if ( !booleanGuid.IsEmpty() )
                {
                    var attribute = AttributeCache.Get( booleanGuid, rockContext );
                    if ( attribute != null )
                    {
                        var dataViewAttributeGuid = GetAttributeValue( action, "DataView" ).AsGuid();
                        if ( dataViewAttributeGuid != Guid.Empty )
                        {
                            var dataView = DataViewCache.Get( dataViewAttributeGuid );
                            if ( dataView != null )
                            {
                                var timeout = GetAttributeValue( action, "Timeout" ).AsIntegerOrNull();
                                Stopwatch stopwatch = Stopwatch.StartNew();
                                var qry = dataView.GetQuery( new Reporting.GetQueryableOptions
                                {
                                    DatabaseTimeoutSeconds = timeout
                                } );

                                var isPersonFound = false;
                                if ( qry != null )
                                {
                                    isPersonFound = qry.Where( e => e.Id == person.Id ).Any();
                                    stopwatch.Stop();
                                    DataViewService.AddRunDataViewTransaction( dataView.Id,
                                                                    Convert.ToInt32( stopwatch.Elapsed.TotalMilliseconds ) );
                                }

                                if ( isPersonFound )
                                { 
                                    SetWorkflowAttributeValue( action, booleanGuid, "True" );
                                }
                                else
                                {
                                    SetWorkflowAttributeValue( action, booleanGuid, "False" );
                                }
                            }
                        }
                    }
                    else
                    {
                        errorMessages.Add( "DataView could not be found." );
                    }
                }
            }
            else
            {
                errorMessages.Add( "No person was provided for DataView." );
            }

            errorMessages.ForEach( m => action.AddLogEntry( m, true ) );

            return true;
        }

        private Person GetPersonAliasFromActionAttribute( string key, RockContext rockContext, WorkflowAction action, List<string> errorMessages )
        {
            string value = GetAttributeValue( action, key );
            Guid guidPersonAttribute = value.AsGuid();
            if ( !guidPersonAttribute.IsEmpty() )
            {
                var attributePerson = AttributeCache.Get( guidPersonAttribute, rockContext );
                if ( attributePerson != null )
                {
                    string attributePersonValue = action.GetWorkflowAttributeValue( guidPersonAttribute );
                    if ( !string.IsNullOrWhiteSpace( attributePersonValue ) )
                    {
                        if ( attributePerson.FieldType.Class == "Rock.Field.Types.PersonFieldType" )
                        {
                            Guid personAliasGuid = attributePersonValue.AsGuid();
                            if ( !personAliasGuid.IsEmpty() )
                            {
                                PersonAliasService personAliasService = new PersonAliasService( rockContext );
                                return personAliasService.Queryable().AsNoTracking()
                                    .Where( a => a.Guid.Equals( personAliasGuid ) )
                                    .Select( a => a.Person )
                                    .FirstOrDefault();
                            }
                            else
                            {
                                errorMessages.Add( string.Format( "Person could not be found for selected value ('{0}')!", guidPersonAttribute.ToString() ) );
                                return null;
                            }
                        }
                        else
                        {
                            errorMessages.Add( string.Format( "The attribute used for {0} to provide the person was not of type 'Person'.", key ) );
                            return null;
                        }
                    }
                }
            }

            return null;
        }

    }
}