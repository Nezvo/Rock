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

import { GroupAttendanceDetailDateSelectionMode } from "@Obsidian/Enums/Blocks/Group/GroupAttendanceDetail/groupAttendanceDetailDateSelectionMode";
import { GroupAttendanceDetailLocationSelectionMode } from "@Obsidian/Enums/Blocks/Group/GroupAttendanceDetail/groupAttendanceDetailLocationSelectionMode";
import { GroupAttendanceDetailScheduleSelectionMode } from "@Obsidian/Enums/Blocks/Group/GroupAttendanceDetail/groupAttendanceDetailScheduleSelectionMode";
import { Guid } from "@Obsidian/Types";
import { GroupAttendanceDetailAttendanceBag } from "@Obsidian/ViewModels/Blocks/Group/GroupAttendanceDetail/groupAttendanceDetailAttendanceBag";
import { ListItemBag } from "@Obsidian/ViewModels/Utility/listItemBag";

/** A bag that contains the information required to render the Obsidian Group Attendance Detail block. */
export type GroupAttendanceDetailInitializationBox = {
    /** Gets or sets the add group member page URL. */
    addGroupMemberPageUrl?: string | null;

    /** Gets or sets the add person as. */
    addPersonAs?: string | null;

    /** Gets or sets the attendance occurrence date (time ignored). */
    attendanceOccurrenceDate?: string | null;

    /** Gets or sets the attendance occurrence date selection mode. */
    attendanceOccurrenceDateSelectionMode: GroupAttendanceDetailDateSelectionMode;

    /** Gets or sets the attendance occurrence unique identifier. */
    attendanceOccurrenceGuid?: Guid | null;

    /** Gets or sets the attendance occurrence identifier. */
    attendanceOccurrenceId?: number | null;

    /** Gets or sets the attendance occurrence types. */
    attendanceOccurrenceTypes?: ListItemBag[] | null;

    /** Gets or sets the attendance occurrence types section label. */
    attendanceOccurrenceTypesSectionLabel?: string | null;

    /** Gets or sets the attendances. */
    attendances?: GroupAttendanceDetailAttendanceBag[] | null;

    /** Gets or sets the back page URL. */
    backPageUrl?: string | null;

    /**
     * Gets or sets the error message. A non-empty value indicates that
     * an error is preventing the block from being displayed.
     */
    errorMessage?: string | null;

    /** Gets or sets the group unique identifier. */
    groupGuid: Guid;

    /** Gets or sets the group members section label. */
    groupMembersSectionLabel?: string | null;

    /** Gets or sets the name of the group. */
    groupName?: string | null;

    /** Gets or sets a value indicating whether this instance is attendance occurrence types section shown. */
    isAttendanceOccurrenceTypesSectionShown: boolean;

    /** Gets or sets a value indicating whether an authorized group was not found. */
    isAuthorizedGroupNotFoundError: boolean;

    /** Gets or sets a value indicating whether this instance is back button hidden. */
    isBackButtonHidden: boolean;

    /** Gets or sets a value indicating whether this instance is campus filtering allowed. */
    isCampusFilteringAllowed: boolean;

    /** Gets a value indicating whether there is a configuration error. */
    isConfigError: boolean;

    /** Gets or sets a value indicating if date is included in the pick from schedule picker. */
    isDateIncludedInPickFromSchedule: boolean;

    /** Gets or sets a value indicating whether this instance is did not meet checked. */
    isDidNotMeetChecked: boolean;

    /** Gets or sets a value indicating whether this instance is did not meet disabled. */
    isDidNotMeetDisabled: boolean;

    /** Gets or sets a value indicating whether this instance is future occurrence date selection restricted. */
    isFutureOccurrenceDateSelectionRestricted: boolean;

    /** Gets or sets a value indicating whether location is required. */
    isLocationRequired: boolean;

    /** Gets or sets a value indicating whether this instance is long list disabled. */
    isLongListDisabled: boolean;

    /** Gets or sets a value indicating whether this instance is new attendance date addition restricted. */
    isNewAttendanceDateAdditionRestricted: boolean;

    /** Gets or sets a value indicating whether this instance is new attendee addition allowed. */
    isNewAttendeeAdditionAllowed: boolean;

    /** Gets or sets a value indicating whether this instance is no attendance occurrences error. */
    isNoAttendanceOccurrencesError: boolean;

    /** Gets or sets a value indicating whether this instance is notes section hidden. */
    isNotesSectionHidden: boolean;

    /** Gets or sets a value indicating whether roster download is shown. */
    isRosterDownloadShown: boolean;

    /** Gets or sets a value indicating whether schedule is required. */
    isScheduleRequired: boolean;

    /** Gets or sets the location unique identifier. */
    locationGuid?: Guid | null;

    /** Gets or sets the location label. */
    locationLabel?: string | null;

    /** Gets or sets the location selection mode. */
    locationSelectionMode: GroupAttendanceDetailLocationSelectionMode;

    /** Gets or sets the navigation urls. */
    navigationUrls?: Record<string, string> | null;

    /** Gets or sets the notes. */
    notes?: string | null;

    /** Gets or sets the notes section label. */
    notesSectionLabel?: string | null;

    /** The number of days back appear in the schedule drop down list to choose from. */
    numberOfPreviousDaysToShow: number;

    /** Gets or sets the schedule unique identifier. */
    scheduleGuid?: Guid | null;

    /** Gets or sets the schedule label. */
    scheduleLabel?: string | null;

    /** Gets or sets the schedule selection mode. */
    scheduleSelectionMode: GroupAttendanceDetailScheduleSelectionMode;

    /** Gets or sets the security grant token. */
    securityGrantToken?: string | null;

    /** Gets or sets the selected attendance occurrence type value. */
    selectedAttendanceOccurrenceTypeValue?: string | null;
};
