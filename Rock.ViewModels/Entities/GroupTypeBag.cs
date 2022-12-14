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

using System;
using System.Linq;

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Entities
{
    /// <summary>
    /// GroupType View Model
    /// </summary>
    public partial class GroupTypeBag : EntityBagBase
    {
        /// <summary>
        /// Gets or sets the administrator term for the group of this GroupType.
        /// </summary>
        /// <value>
        /// The administrator term for the group of this GroupType.
        /// </value>
        public string AdministratorTerm { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if group type allows any child group type.
        /// </summary>
        /// <value>
        ///   true if [allow any child group type]; otherwise, false.
        /// </value>
        public bool AllowAnyChildGroupType { get; set; }

        /// <summary>
        /// Gets or sets the allowed schedule types.
        /// </summary>
        /// <value>
        /// The allowed schedule types.
        /// </value>
        public int AllowedScheduleTypes { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if groups of this type are allowed to be sync'ed.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if groups of this type are allowed to be sync'ed, otherwise false.
        /// </value>
        public bool AllowGroupSync { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if Groups of this type are allowed to have multiple locations.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if a Rock.Model.Group of this GroupType are allowed to have multiple locations; otherwise false.
        /// </value>
        public bool AllowMultipleLocations { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if specific groups are allowed to have their own member attributes.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if this specific group are allowed to have their own member attributes, otherwise false.
        /// </value>
        public bool AllowSpecificGroupMemberAttributes { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if groups of this type should be allowed to have Group Member Workflows.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if groups of this type should be allowed to have group member workflows, otherwise false.
        /// </value>
        public bool AllowSpecificGroupMemberWorkflows { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [attendance counts as weekend service].
        /// </summary>
        /// <value>
        /// true if [attendance counts as weekend service]; otherwise, false.
        /// </value>
        public bool AttendanceCountsAsWeekendService { get; set; }

        /// <summary>
        /// Gets or sets the Rock.Model.PrintTo indicating the type of  location of where attendee labels for Groups of this GroupType should print.
        /// </summary>
        /// <value>
        /// A Rock.Model.PrintTo enum value indicating how and where attendee labels for Groups of this GroupType should print.
        /// </value>
        public int AttendancePrintTo { get; set; }

        /// <summary>
        /// Gets or sets the Rock.Model.AttendanceRule that indicates how attendance is managed a Rock.Model.Group of this GroupType
        /// </summary>
        /// <value>
        /// The Rock.Model.AttendanceRule that indicates how attendance is managed for a Rock.Model.Group of this GroupType.
        /// </value>
        public int AttendanceRule { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Rock.Model.GroupTypeRole that a Rock.Model.GroupMember of a Rock.Model.Group belonging to this GroupType is given by default.
        /// </summary>
        /// <value>
        /// A System.Int32 representing the Id of the Rock.Model.GroupTypeRole that a Rock.Model.GroupMember of a Rock.Model.Group belonging to this GroupType is given by default.
        /// </value>
        public int? DefaultGroupRoleId { get; set; }

        /// <summary>
        /// Gets or sets the Description of the GroupType.
        /// </summary>
        /// <value>
        /// A System.String representing the description of the GroupType.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether group history should be enabled for groups of this type
        /// </summary>
        /// <value>
        ///   true if [enable group history]; otherwise, false.
        /// </value>
        public bool EnableGroupHistory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether group tag should be enabled for groups of this type
        /// </summary>
        /// <value>
        ///   true if [enable group tag]; otherwise, false.
        /// </value>
        public bool EnableGroupTag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable inactive reason].
        /// </summary>
        /// <value>
        ///   true if [enable inactive reason]; otherwise, false.
        /// </value>
        public bool EnableInactiveReason { get; set; }

        /// <summary>
        /// Gets or sets the enable location schedules.
        /// </summary>
        /// <value>
        /// The enable location schedules.
        /// </value>
        public bool? EnableLocationSchedules { get; set; }

        /// <summary>
        /// Indicates whether RSVP functionality should be enabled for this group.
        /// </summary>
        /// <value>
        /// A boolean value.
        /// </value>
        public bool EnableRSVP { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if group requirements section is enabled for group of this type.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if group requirements section is enabled for group of this type, otherwise false.
        /// </value>
        public bool EnableSpecificGroupRequirements { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [group attendance requires location].
        /// </summary>
        /// <value>
        /// true if [group attendance requires location]; otherwise, false.
        /// </value>
        public bool GroupAttendanceRequiresLocation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [group attendance requires schedule].
        /// </summary>
        /// <value>
        /// true if [group attendance requires schedule]; otherwise, false.
        /// </value>
        public bool GroupAttendanceRequiresSchedule { get; set; }

        /// <summary>
        /// Gets or sets the group capacity rule.
        /// </summary>
        /// <value>
        /// The group capacity rule.
        /// </value>
        public int GroupCapacityRule { get; set; }

        /// <summary>
        /// Gets or sets the term that a Rock.Model.GroupMember of a Rock.Model.Group that belongs to this GroupType is called.
        /// </summary>
        /// <value>
        /// A System.String that represents the term that a Rock.Model.GroupMember of a Rock.Model.Group belonging to this
        /// GroupType is called.
        /// </value>
        public string GroupMemberTerm { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [groups require campus].
        /// </summary>
        /// <value>
        ///   true if [groups require campus]; otherwise, false.
        /// </value>
        public bool GroupsRequireCampus { get; set; }

        /// <summary>
        /// Gets or sets the DefinedType that Groups of this type will use for the Group.StatusValue
        /// </summary>
        /// <value>
        /// The group status defined type identifier.
        /// </value>
        public int? GroupStatusDefinedTypeId { get; set; }

        /// <summary>
        /// Gets or sets the term that a Rock.Model.Group belonging to this Rock.Model.GroupType is called.
        /// </summary>
        /// <value>
        /// A System.String representing the term that a Rock.Model.Group belonging to this Rock.Model.GroupType is called.
        /// </value>
        public string GroupTerm { get; set; }

        /// <summary>
        /// The color used to visually distinguish groups on lists.
        /// </summary>
        /// <value>
        /// The group type color.
        /// </value>
        public string GroupTypeColor { get; set; }

        /// <summary>
        /// Gets or sets Id of the Rock.Model.DefinedValue that represents the purpose of the GroupType.
        /// </summary>
        /// <value>
        /// An System.Int32 representing the Id of the Rock.Model.DefinedValue that represents the purpose of the GroupType.
        /// </value>
        public int? GroupTypePurposeValueId { get; set; }

        /// <summary>
        /// Gets or sets a lava template that can be used for generating  view details for Group.
        /// </summary>
        /// <value>
        /// The Group View Lava Template.
        /// </value>
        public string GroupViewLavaTemplate { get; set; }

        /// <summary>
        /// Gets or sets the icon CSS class name for a font vector based icon.
        /// </summary>
        /// <value>
        /// A System.String representing the CSS class name of a font based icon.
        /// </value>
        public string IconCssClass { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore person inactivated.
        /// By default group members are inactivated in their group whenever the person
        /// is inactivated. If this value is set to true, members in groups of this type
        /// will not be marked inactive when the person is inactivated
        /// </summary>
        /// <value>
        /// true if [ignore person inactivated]; otherwise, false.
        /// </value>
        public bool IgnorePersonInactivated { get; set; }

        /// <summary>
        /// Gets or sets the Id of the GroupType to inherit settings and properties from. This is essentially copying the values, but they can be overridden.
        /// </summary>
        /// <value>
        /// A System.Int32 representing the Id of a GroupType to inherit properties and values from.
        /// </value>
        public int? InheritedGroupTypeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is capacity required.
        /// </summary>
        /// <value>
        /// true if this instance is capacity required; otherwise, false.
        /// </value>
        public bool IsCapacityRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is index enabled.
        /// </summary>
        /// <value>
        /// true if this instance is index enabled; otherwise, false.
        /// </value>
        public bool IsIndexEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether scheduling is enabled for groups of this type
        /// </summary>
        /// <value>
        ///   true if this instance is scheduling enabled; otherwise, false.
        /// </value>
        public bool IsSchedulingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if this GroupType is part of the Rock core system/framework.  This property is required.
        /// </summary>
        /// <value>
        /// A System.Boolean that is true if this GroupType is part of the Rock core system/framework.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets selection mode that the Location Picker should use when adding locations to groups of this type
        /// </summary>
        /// <value>
        /// The Rock.Web.UI.Controls.LocationPickerMode to use when adding location(s) to Groups
        /// of this GroupType. This can be one or more of the following values
        /// </value>
        public int LocationSelectionMode { get; set; }

        /// <summary>
        /// Gets or sets the Name of the GroupType. This property is required.
        /// </summary>
        /// <value>
        /// A System.String representing the Name of the GroupType.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order for this GroupType. This is used for display and priority purposes, the lower the number the higher the priority, or the higher the GroupType is displayed. This property is required.
        /// </summary>
        /// <value>
        /// A System.Int32 representing the display/priority order for this GroupType.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [requires inactive reason].
        /// </summary>
        /// <value>
        ///   true if [requires inactive reason]; otherwise, false.
        /// </value>
        public bool RequiresInactiveReason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a person must specify a reason when declining/cancelling.
        /// </summary>
        /// <value>
        ///   true if [requires reason if decline schedule]; otherwise, false.
        /// </value>
        public bool RequiresReasonIfDeclineSchedule { get; set; }

        /// <summary>
        /// Gets or sets the number of days prior to the RSVP date that a reminder should be sent.
        /// </summary>
        /// <value>
        /// The number of days.
        /// </value>
        public int? RSVPReminderOffsetDays { get; set; }

        /// <summary>
        /// Gets or sets the system communication to use for sending an RSVP reminder.
        /// </summary>
        /// <value>
        /// The RSVP reminder system communication identifier.
        /// </value>
        public int? RSVPReminderSystemCommunicationId { get; set; }

        /// <summary>
        /// Gets or sets the WorkflowType to execute when a person indicates they won't be able to attend at their scheduled time
        /// </summary>
        /// <value>
        /// The schedule cancellation workflow type identifier.
        /// </value>
        public int? ScheduleCancellationWorkflowTypeId { get; set; }

        /// <summary>
        /// Gets or sets the number of days prior to the schedule to send a confirmation email.
        /// </summary>
        /// <value>
        /// The schedule confirmation email offset days.
        /// </value>
        public int? ScheduleConfirmationEmailOffsetDays { get; set; }

        /// <summary>
        /// Gets or sets the schedule confirmation logic.
        /// </summary>
        /// <value>
        /// The schedule confirmation logic.
        /// </value>
        public int ScheduleConfirmationLogic { get; set; }

        /// <summary>
        /// Gets or sets the system communication to use when a person is scheduled or when the schedule has been updated.
        /// </summary>
        /// <value>
        /// The scheduled system communication identifier.
        /// </value>
        public int? ScheduleConfirmationSystemCommunicationId { get; set; }

        /// <summary>
        /// Gets or sets the number of days prior to the schedule to send a reminder email. See also Rock.Model.GroupMember.ScheduleReminderEmailOffsetDays.
        /// </summary>
        /// <value>
        /// The schedule reminder email offset days.
        /// </value>
        public int? ScheduleReminderEmailOffsetDays { get; set; }

        /// <summary>
        /// Gets or sets the system communication to use when sending a schedule reminder.
        /// </summary>
        /// <value>
        /// The schedule reminder system communication identifier.
        /// </value>
        public int? ScheduleReminderSystemCommunicationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if an attendance reminder should be sent to group leaders.
        /// </summary>
        /// <value>
        /// true if [send attendance reminder]; otherwise, false.
        /// </value>
        public bool SendAttendanceReminder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether administrator for the group of this GroupType will be shown.
        /// </summary>
        /// <value>
        ///   A System.Boolean value that is true if administrator for the group of this GroupType will be shown; otherwise false.
        /// </value>
        public bool ShowAdministrator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the Person's connection status as a column in the Group Member Grid
        /// </summary>
        /// <value>
        /// true if [show connection status]; otherwise, false.
        /// </value>
        public bool ShowConnectionStatus { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if a Rock.Model.Group of this GroupType will be shown in the group list.
        /// </summary>
        /// <value>
        ///   A System.Boolean value that is true if a Rock.Model.Group of this GroupType will be shown in the GroupList; otherwise false.
        /// </value>
        public bool ShowInGroupList { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if this GroupType and its Groups are shown in Navigation.
        /// If false, this GroupType will be hidden navigation controls, such as TreeViews and Menus
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if this GroupType and Groups should be displayed in Navigation controls.
        /// </value>
        public bool ShowInNavigation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the Person's marital status as a column in the Group Member Grid
        /// </summary>
        /// <value>
        /// true if [show marital status]; otherwise, false.
        /// </value>
        public bool ShowMaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if a Rock.Model.Group of this GroupType supports taking attendance.
        /// </summary>
        /// <value>
        /// A System.Boolean representing if a Rock.Model.Group of this GroupType supports taking attendance.
        /// </value>
        public bool TakesAttendance { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>
        /// The created date time.
        /// </value>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the modified date time.
        /// </summary>
        /// <value>
        /// The modified date time.
        /// </value>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the created by person alias identifier.
        /// </summary>
        /// <value>
        /// The created by person alias identifier.
        /// </value>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the modified by person alias identifier.
        /// </summary>
        /// <value>
        /// The modified by person alias identifier.
        /// </value>
        public int? ModifiedByPersonAliasId { get; set; }

    }
}
