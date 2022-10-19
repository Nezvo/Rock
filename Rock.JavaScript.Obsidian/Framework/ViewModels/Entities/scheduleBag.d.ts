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

import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

/** Schedule View Model */
export type ScheduleBag = {
    /**
     * Gets or sets the shortened name of the attribute.
     * If null or whitespace then the full name is returned.
     */
    abbreviatedName?: string | null;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets a value indicating whether [auto inactivate when complete]. */
    autoInactivateWhenComplete: boolean;

    /** Gets or sets the CategoryId of the Rock.Model.Category that this Schedule belongs to. */
    categoryId?: number | null;

    /**
     * Gets or sets the number of minutes following schedule start that Check-in should be active. 0 represents that Check-in will only be available
     * until the Schedule's start time.
     */
    checkInEndOffsetMinutes?: number | null;

    /**
     * Gets or sets the number of minutes prior to the Schedule's start time  that Check-in should be active. 0 represents that Check-in 
     * will not be available to the beginning of the event.
     */
    checkInStartOffsetMinutes?: number | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets a user defined Description of the Schedule. */
    description?: string | null;

    /** Gets or sets that date that this Schedule expires and becomes inactive. This value is inclusive and the schedule will be inactive after this date. */
    effectiveEndDate?: string | null;

    /** Gets or sets the Date that the Schedule becomes effective/active. This property is inclusive, and the schedule will be inactive before this date.  */
    effectiveStartDate?: string | null;

    /** Gets or sets the content lines of the iCalendar */
    iCalendarContent?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a flag indicating if this is an active schedule. This value is required. */
    isActive: boolean;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the Name of the Schedule. This property is required. */
    name?: string | null;

    /**
     * Gets or sets the order.
     * Use List&lt;Schedule&gt;().OrderByOrderAndNextScheduledDateTime
     * to get the schedules in the desired order.
     */
    order: number;

    /** Gets or sets the weekly day of week. */
    weeklyDayOfWeek?: number | null;
};
