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
//

using System;

using Rock.Enums.Cms;

namespace Rock.Cms
{
    /// <summary>
    /// Specifies the default role instances of this block type will have when
    /// added to a page. Individual Block instances can override this via the
    /// block's configuration UI.
    /// </summary>
    [AttributeUsage( AttributeTargets.Class, AllowMultiple = false )]
    public class BlockRoleAttribute : System.Attribute
    {
        #region Properties

        /// <summary>
        /// The default role for the block if not specified in the block's
        /// configuration.
        /// </summary>
        public BlockRole Role { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockRoleAttribute"/> class.
        /// </summary>
        /// <param name="role">The default role for the block if not specified in the block's configuration.</param>
        public BlockRoleAttribute( BlockRole role )
        {
            Role = role;
        }

        #endregion
    }
}
