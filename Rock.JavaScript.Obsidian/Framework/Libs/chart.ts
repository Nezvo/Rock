export * from "chart.js/auto";
export type { AnnotationPluginOptions } from "chartjs-plugin-annotation";

import { Chart } from "chart.js/auto";
import annotationPlugin from "chartjs-plugin-annotation";
import ChartDataLabels from "chartjs-plugin-datalabels";
import { Options as ChartDataLabelsOptions, LabelOptions as ChartDataLabelOptions } from "chartjs-plugin-datalabels/types/options";
import "chartjs-adapter-luxon";

Chart.register(annotationPlugin);
//Chart.register(ChartDataLabels); // Register plugin in charts that need it.

export { ChartDataLabels, type ChartDataLabelsOptions, type ChartDataLabelOptions };
