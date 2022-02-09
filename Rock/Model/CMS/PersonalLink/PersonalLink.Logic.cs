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

namespace Rock.Model
{
    public partial class PersonalLink
    {
        /// <summary>
        /// Return <c>true</c> if the user is authorized for <paramref name="action"/>.
        /// In the case of non-shared link, security it limited to the person who owns that section.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="person">The person.</param>
        /// <returns><c>true</c> if the specified action is authorized; otherwise, <c>false</c>.</returns>
        public override bool IsAuthorized( string action, Person person )
        {
            // if it is non-shared personal link, than only the person that owns the link is authorized for that link. Everybody else has NO access (including admins).
            if ( this.PersonAlias != null )
            {
                return this.PersonAlias.PersonId == person.Id;
            }

            return base.IsAuthorized( action, person );
        }
    }
}
