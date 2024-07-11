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

import { CheckInStatus } from "@Obsidian/Enums/Event/checkInStatus";

/**
 * A minimal representation of a single attendance record used to track
 * counts.
 */
export type ActiveAttendanceBag = {
    /** The encrypted identifier of the area used for check-in. */
    areaId?: string | null;

    /** The encrypted identifier of the group used for check-in. */
    groupId?: string | null;

    /** The encrypted identifier of the attendance record. */
    id?: string | null;

    /** The encrypted identifier of the location used for check-in. */
    locationId?: string | null;

    /** The status of the attendance record. */
    status: CheckInStatus;
};
