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

namespace Rock.Model
{
    public partial class PluginMigration
    {
        #region Methods

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this PluginMigration.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this PluginMigration.
        /// </returns>
        public override string ToString()
        {
            return string.Format( "{0} ({1})", this.PluginAssemblyName, this.MigrationNumber );
        }

        #endregion Methods
    }
}
