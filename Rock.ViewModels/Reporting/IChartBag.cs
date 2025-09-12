using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rock.ViewModels.Blocks.Reporting;
using Rock.ViewModels.Reporting.PieChart;

namespace Rock.ViewModels.Reporting
{
    /// <summary>
    /// Defines the contract for a chart bag, which contains the labels, series data, and chart options for a chart.
    /// </summary>
    public interface IChartBag
    {
        /// <summary>
        /// Gets or sets the labels for the chart.
        /// </summary>
        /// <value>
        /// A <see cref="List{T}"/> of <see cref="string"/> values representing the labels for the chart.
        /// </value>
        List<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the series bags for the chart.
        /// </summary>
        /// <value>
        /// A <see cref="List{T}"/> of <see cref="PieSeriesBag"/> objects representing the data series for the chart.
        /// </value>
        List<IChartSeriesBag> SeriesBags { get; set; }

        /// <summary>
        /// Gets or sets the chart options bag.
        /// </summary>
        /// <value>
        /// A <see cref="ChartOptionsBag"/> object containing configuration options for the chart.
        /// </value>
        ChartOptionsBag ChartOptionsBag { get; set; }
    }
}
