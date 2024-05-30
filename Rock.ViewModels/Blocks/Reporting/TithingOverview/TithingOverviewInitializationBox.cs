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

namespace Rock.ViewModels.Blocks.Reporting.TithingOverview
{
    /// <summary>
    /// Contains all the initialization information for the Tithing Overview block.
    /// </summary>
    /// <seealso cref="BlockBox" />
    public class TithingOverviewInitializationBox : BlockBox
    {
        /// <summary>
        /// Gets or sets the chart data json.
        /// </summary>
        /// <value>
        /// The chart data json.
        /// </value>
        public string ChartDataJson { get; set; }

        /// <summary>
        /// Gets or sets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public string ChartType { get; set; }

        /// <summary>
        /// Gets or sets the tool tip data.
        /// </summary>
        /// <value>
        /// The tool tip data.
        /// </value>
        public Dictionary<string, TithingOverviewToolTipBag> ToolTipData { get; set; }

        /// <summary>
        /// Gets or sets the legend data.
        /// </summary>
        /// <value>
        /// The legend data.
        /// </value>
        public Dictionary<string, string> LegendData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the data required to create the chart exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the data exists, <c>false</c>.
        /// </value>
        public bool HasData { get; set; }
    }
}
