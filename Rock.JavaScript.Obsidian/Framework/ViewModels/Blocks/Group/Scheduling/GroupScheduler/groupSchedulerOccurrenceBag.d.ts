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

/** The information needed to identify a specific occurrence to be scheduled within the Group Scheduler. */
export type GroupSchedulerOccurrenceBag = {
    /**
     * Gets or sets the attendance occurrence ID for this occurrence.
     * This attendance occurrence might not exist yet.
     */
    attendanceOccurrenceId?: number | null;

    /** Gets or sets the desired capacity for this occurrence. */
    desiredCapacity?: number | null;

    /** Gets or sets the group ID for this occurrence. */
    groupId: number;

    /** Gets or sets the group location order for this occurrence. */
    groupLocationOrder: number;

    /** Gets or sets the group name for this occurrence. */
    groupName?: string | null;

    /** Gets the unique identifier for this group scheduler occurrence. */
    guid: Guid;

    /** Gets or sets whether scheduling is enabled for this occurrence. */
    isSchedulingEnabled: boolean;

    /** Gets or sets the location ID for this occurrence. */
    locationId: number;

    /** Gets or sets the location name for this occurrence. */
    locationName?: string | null;

    /** Gets or sets the maximum capacity for this occurrence. */
    maximumCapacity?: number | null;

    /** Gets or sets the minimum capacity for this occurrence. */
    minimumCapacity?: number | null;

    /** Gets the occurrence date. */
    occurrenceDate?: string | null;

    /** Gets or sets the occurrence date and time. */
    occurrenceDateTime?: string | null;

    /** Gets or sets the parent group ID (if any) for this occurrence. */
    parentGroupId?: number | null;

    /** Gets or sets the parent group name (if any) for this occurrence. */
    parentGroupName?: string | null;

    /** Gets or sets the schedule ID for this occurrence. */
    scheduleId: number;

    /** Gets or sets the schedule name for this occurrence. */
    scheduleName?: string | null;

    /** Gets or sets the schedule order for this occurrence. */
    scheduleOrder: number;

    /** Gets or sets the ISO 8601 Sunday date for this occurrence. */
    sundayDate?: string | null;
};
