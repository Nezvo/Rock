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

using System.Collections.Generic;

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Blocks.Reporting.DynamicData
{
    /// <summary>
    /// The settings options that will be available for selection in the custom settings panel for the dynamic data block.
    /// </summary>
    public class DynamicDataCustomSettingsOptionsBag
    {
        /// <summary>
        /// Gets or sets the display mode items.
        /// </summary>
        public List<ListItemBag> DisplayModeItems { get; set; }

        /// <summary>
        /// Gets or sets the column type items for the grid.
        /// </summary>
        public List<ListItemBag> ColumnTypeItems { get; set; }

        /// <summary>
        /// Gets or sets the visible priority items for the grid.
        /// </summary>
        public List<ListItemBag> VisiblePriorityItems { get; set; }
    }
}
