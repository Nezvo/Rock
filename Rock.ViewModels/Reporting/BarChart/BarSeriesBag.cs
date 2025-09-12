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
using System.Collections.Generic;

using Rock.ViewModels.Blocks.Reporting;

namespace Rock.ViewModels.Reporting.BarChart
{
    /// <summary>
    /// Represents a single bar series in a bar chart, including its label, data points, colors, opacity, and label configuration.
    /// </summary>
    public class BarSeriesBag : IChartSeriesBag
    {
        /// <summary>
        /// Gets or sets the label for the bar series.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the data points for the bar series.
        /// </summary>
        public List<double> Data { get; set; }

        /// <summary>
        /// Gets or sets the color of the bars.
        /// Can be a single color value or a comma-separated list for each data point.
        /// </summary>
        public List<string> Color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the bars are unfilled.
        /// If true, bars are rendered as outlines; otherwise, they are filled.
        /// </summary>
        public bool? IsUnfilled { get; set; }

        /// <summary>
        /// Gets or sets the opacity of the bars (range 0-1).
        /// Can be a single value or an array for each data point.
        /// </summary>
        public double?[] Opacity { get; set; }

        /// <summary>
        /// Gets or sets the configuration for the bar labels.
        /// The dictionary maps label keys to label text.
        /// </summary>
        public BarLabelsConfig BarLabels { get; set; }
    }

    #region Bar Label Enums

    /// <summary>
    /// Specifies the position of the bar label in a bar chart.
    /// </summary>
    public enum BarLabelPosition
    {
        /// <summary>
        /// The label is displayed inside the bar.
        /// </summary>
        Inside,

        /// <summary>
        /// The label is displayed outside the bar.
        /// </summary>
        Outside,
    }

    #endregion Bar Label Enums

    #region Bar Label Support Classes

    /// <summary>
    /// Provides context information for a bar label in a bar chart.
    /// </summary>
    public class BarLabelContext
    {
        /// <summary>
        /// Gets or sets the dataset (series) label, e.g. "Revenue".
        /// </summary>
        public string SeriesName { get; set; }

        /// <summary>
        /// Gets or sets the category label on the cross-axis, e.g. "Jan".
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the formatted version of the label (may be null).
        /// </summary>
        public string FormattedLabel { get; set; }

        /// <summary>
        /// Gets or sets the numeric value that determines bar length.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the formatted version of the value (may be null).
        /// </summary>
        public string FormattedValue { get; set; }
    }

    /// <summary>
    /// Provides specification for a bar label in a bar chart.
    /// </summary>
    public class BarLabelSpec
    {
        /// <summary>
        /// Gets or sets the function that builds the text for this line. Supports multiline with \n.
        /// </summary>
        public Func<BarLabelContext, string> Formatter { get; set; }

        /// <summary>
        /// Gets or sets the color of the label text.
        /// </summary>
        public string Color { get; set; }
    }

    /// <summary>
    /// Provides configuration for bar labels in a bar chart, including position and label specification.
    /// </summary>
    public class BarLabelsConfig
    {
        /// <summary>
        /// Gets or sets the position of the bar label (inside or outside the bar).
        /// </summary>
        public BarLabelPosition BarLabelPosition { get; set; }

        /// <summary>
        /// Gets or sets the specification for the bar label, such as formatting and color.
        /// </summary>
        public BarLabelSpec BarLabelSpec { get; set; }
    }

    #endregion Bar Label Support Classes
}