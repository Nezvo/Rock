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

import { Guid } from "@Obsidian/Types";
import { SignUpOccurrenceLocationBag } from "@Obsidian/ViewModels/Blocks/Group/Scheduling/GroupScheduleToolbox/signUpOccurrenceLocationBag";

/** A bag that contains information about an additional time sign-up occurrence for the group schedule toolbox block. */
export type SignUpOccurrenceBag = {
    /** Gets whether all of this sign-up occurrence's locations are at maximum capacity. */
    areAllLocationsAtMaximumCapacity: boolean;

    /** Gets or sets the formatted occurrence schedule name. */
    formattedScheduleName?: string | null;

    /** Gets or sets whether this occurrence represents an immediate need. */
    isImmediateNeed: boolean;

    /** Gets or sets the locations that may be selected for this occurrence. */
    locations?: SignUpOccurrenceLocationBag[] | null;

    /** Gets this sign-up occurrence's location sort name. */
    locationSortName?: string | null;

    /** Gets this sign-up occurrence's location sort order. */
    locationSortOrder: number;

    /** Gets or sets the occurrence date time. */
    occurrenceDateTime?: string | null;

    /** Gets the count of people needed for this sign-up occurrence, across all locations. */
    peopleNeededCount: number;

    /** Gets or sets the count of people scheduled for this occurrence without a location specified. */
    peopleScheduledWithoutLocationCount: number;

    /** Gets or sets the occurrence schedule unique identifier. */
    scheduleGuid: Guid;

    /** Gets or sets the occurrence schedule name. */
    scheduleName?: string | null;
};
