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

using System.Collections.Generic;

using Rock.ViewModels.Blocks.Reporting;

namespace Rock.ViewModels.Reporting.LineChart
{
    /// <summary>
    /// Represents a line chart, including its labels, line series, and configuration.
    /// </summary>
    public class LineChartBag : IChartBag
    {
        /// <summary>
        /// Gets or sets the labels for the data points.
        /// </summary>
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets one or more line series data.
        /// </summary>
        public List<IChartSeriesBag> SeriesBags { get; set; }

        /// <summary>
        /// Gets or sets the chart options bag, which contains configuration options for the chart.
        /// </summary>
        public ChartOptionsBag ChartOptionsBag { get; set; }
    }
}