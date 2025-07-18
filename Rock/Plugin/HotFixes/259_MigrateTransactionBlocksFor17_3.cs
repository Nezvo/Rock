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

namespace Rock.Plugin.HotFixes
{
    /// <summary>
    /// Plug-in migration
    /// </summary>
    /// <seealso cref="Rock.Plugin.Migration" />
    [MigrationNumber( 259, "17.3" )]
    public class MigrateTransactionBlocksFor17_3 : Migration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            Sql( @"
UPDATE [BlockType] SET [Name] = 'Scheduled Transaction Edit (Legacy)' WHERE [Guid] = '5171C4E5-7698-453E-9CC8-088D362296DE';
UPDATE [BlockType] SET [Name] = 'Scheduled Transaction Edit' WHERE [Guid] = 'F1ADF375-7442-4B30-BAC3-C387EA9B6C18';
UPDATE [BlockType] SET [Path] = '~/Blocks/Finance/TransactionEntryLegacy.ascx' WHERE [Path] = '~/Blocks/Finance/TransactionEntry.ascx';
" );
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            Sql( @"
UPDATE [BlockType] SET [Name] = 'Scheduled Transaction Edit' WHERE [Guid] = '5171C4E5-7698-453E-9CC8-088D362296DE';
UPDATE [BlockType] SET [Name] = 'Scheduled Transaction Edit (V2)' WHERE [Guid] = 'F1ADF375-7442-4B30-BAC3-C387EA9B6C18';
UPDATE [BlockType] SET [Path] = '~/Blocks/Finance/TransactionEntry.ascx' WHERE [Path] = '~/Blocks/Finance/TransactionEntryLegacy.ascx';
" );
        }
    }
}