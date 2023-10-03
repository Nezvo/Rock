//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
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

/** The filtering method used for a number column filter. */
export const NumberFilterMethod = {
    /** The cell value must exactly match the filter value. */
    Equals: 0,

    /** The cell value must not match the filter value. */
    DoesNotEqual: 1,

    /** The cell value must be greater than the filter value. */
    GreaterThan: 2,

    /** The cell value must be greater than or equal to the filter value. */
    GreaterThanOrEqual: 3,

    /** The cell value must be less than the filter value. */
    LessThan: 4,

    /** The cell value must be less than or equal to the filter value. */
    LessThanOrEqual: 5,

    /**
     * The cell value must be greater than or equal to the lower filter
     * value and less than or equal to the upper filter value.
     */
    Between: 6,

    /** The cell value must be in the top N values. */
    TopN: 7,

    /** The cell value must be above the calculated average value. */
    AboveAverage: 8,

    /** The cell value must be below the calculate average value. */
    BelowAverage: 9
} as const;

/** The filtering method used for a number column filter. */
export const NumberFilterMethodDescription: Record<number, string> = {
    0: "Equals",

    1: "Does Not Equal",

    2: "Greater Than",

    3: "Greater Than Or Equal",

    4: "Less Than",

    5: "Less Than Or Equal",

    6: "Between",

    7: "Top N",

    8: "Above Average",

    9: "Below Average"
};

/** The filtering method used for a number column filter. */
export type NumberFilterMethod = typeof NumberFilterMethod[keyof typeof NumberFilterMethod];
