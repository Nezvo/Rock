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

/** The age bracket of a person */
export const AgeBracket = {
    /** Unknown Age range */
    Unknown: 0,

    /** Age range 0 - 5 */
    ZeroToFive: 1,

    /** Age range 6 - 12 */
    SixToTwelve: 2,

    /** Age range 13 - 17 */
    ThirteenToSeventeen: 3,

    /** Age range 18 - 24 */
    EighteenToTwentyFour: 4,

    /** Age range 25 - 34 */
    TwentyFiveToThirtyFour: 5,

    /** Age range 35 - 44 */
    ThirtyFiveToFortyFour: 6,

    /** Age range 45 - 54 */
    FortyFiveToFiftyFour: 7,

    /** Age range 55 - 64 */
    FiftyFiveToSixtyFour: 8,

    /** Age range 65+ */
    SixtyFiveOrOlder: 9
} as const;

/** The age bracket of a person */
export const AgeBracketDescription: Record<number, string> = {
    0: "Unknown",

    1: "0 - 5",

    2: "6 - 12",

    3: "13 - 17",

    4: "18 - 24",

    5: "25 - 34",

    6: "35 - 44",

    7: "45 - 54",

    8: "55 - 64",

    9: "65+"
};

/** The age bracket of a person */
export type AgeBracket = typeof AgeBracket[keyof typeof AgeBracket];
