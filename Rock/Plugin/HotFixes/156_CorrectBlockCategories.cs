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

namespace Rock.Plugin.HotFixes
{
    /// <summary>
    /// Plug-in migration
    /// </summary>
    /// <seealso cref="Rock.Plugin.Migration" />
    [MigrationNumber( 156, "1.13.6" )]
    public class CorrectBlockCategories : Migration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            UpdateIncorrectBlockCategories();
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            // Down migrations are not yet supported in plug-in migrations.
        }

        /// <summary>
        /// GJ: Update Incorrect Block Categories
        /// </summary>
        private void UpdateIncorrectBlockCategories()
        {
            Sql( @"
                UPDATE [BlockType] SET [Category]=N'Check-in' WHERE ([Guid]='A5ECE422-D473-4B8F-BEE9-5651AFCB2AB3')
                UPDATE [BlockType] SET [Category]=N'Check-in' WHERE ([Guid]='678ED4B6-D76F-4D43-B069-659E352C9BD8')
                UPDATE [BlockType] SET [Category]=N'Security > Background Check' WHERE ([Guid]='562A5CA4-1697-40E3-A54A-C451291A3251')
                UPDATE [BlockType] SET [Category]=N'Security > Background Check' WHERE ([Guid]='AF36FA7E-BD2A-42A3-AF30-2FEBC1C46663')" );
        }
    }
}
