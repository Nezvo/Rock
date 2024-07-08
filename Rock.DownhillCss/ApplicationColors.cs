﻿// <copyright>
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
namespace Rock.DownhillCss
{
    /// <summary>
    /// This class is used to define the colors used in the Rock Downhill CSS framework.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         These colors are meant to be used in a manner that is both light and dark mode responsive.<br />
    ///         The <see cref="CssUtilities.BuildFramework"/> method generates light and dark mode classes by using the original colors for light mode and then switching the colors to their counterpart for dark mode.<br />
    ///         The "counterpart" is determined by simply inverting the color to the opposite end of the spectrum.<br />
    ///         For example, InterfaceStronger (by default) is #3b3136 in light moode and #f6f7f9 (InterfaceSofter) in dark mode.<br />
    ///         For non-interface colors (primary, secondary, warning, etc.), there are two versions of each color: "Strong" and "Soft". These invert between theme switches.<br />
    ///         Legacy colors should be considered deprecated and are only included for backwards compatibility. They will be removed in a future version of Rock.
    ///     </para>
    /// </remarks>
    public class ApplicationColors
    {
        #region Legacy Colors

        /// <summary>
        /// Gets or sets the primary.
        /// </summary>
        /// <value>
        /// The primary.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Primary { get; set; } = "#007bff";

        /// <summary>
        /// Gets or sets the secondary.
        /// </summary>
        /// <value>
        /// The secondary.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Secondary { get; set; } = "#6c757d";

        /// <summary>
        /// Gets or sets the success.
        /// </summary>
        /// <value>
        /// The success.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Success { get; set; } = "#28a745";

        /// <summary>
        /// Gets or sets the danger.
        /// </summary>
        /// <value>
        /// The danger.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Danger { get; set; } = "#dc3545";

        /// <summary>
        /// Gets or sets the warning.
        /// </summary>
        /// <value>
        /// The warning.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Warning { get; set; } = "#ffc107";

        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Info { get; set; } = "#17a2b8";

        /// <summary>
        /// Gets or sets the light.
        /// </summary>
        /// <value>
        /// The light.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Light { get; set; } = "#f8f9fa";

        /// <summary>
        /// Gets or sets the dark.
        /// </summary>
        /// <value>
        /// The dark.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Dark { get; set; } = "#343a40";

        /// <summary>
        /// Gets or sets the white.
        /// </summary>
        /// <value>
        /// The white.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string White { get; set; } = "#ffffff";

        /// <summary>
        /// Gets or sets the brand color.
        /// </summary>
        /// <value>
        /// The brand.
        /// </value>
        [Obsolete( "These are replaced by interface colors in Rock v16.4." )]
        public string Brand { get; set; } = "#007bff";

        #endregion

        #region Interface Colors

        /// <summary>
        /// The strongest interface color.
        /// </summary>
        public string InterfaceStrongest { get; set; } = "#181a1c";

        /// <summary>
        /// A stronger interface color.
        /// </summary>
        public string InterfaceStronger { get; set; } = "#3b3136";

        /// <summary>
        /// A strong interface color.
        /// </summary>
        public string InterfaceStrong { get; set; } = "#67717a";

        /// <summary>
        /// A medium interface color.
        /// </summary>
        public string InterfaceMedium { get; set; } = "#9aa7b3";

        /// <summary>
        /// A soft interface color.
        /// </summary>
        public string InterfaceSoft { get; set; } = "#e4e8eb";

        /// <summary>
        /// A softer interface color.
        /// </summary>
        public string InterfaceSofter { get; set; } = "#f6f7f9";

        /// <summary>
        /// The softest interface color.
        /// </summary>
        public string InterfaceSoftest { get; set; } = "#ffffff";

        #endregion

        #region Accent Colors

        /// <summary>
        /// The strong variant of the primary color.
        /// </summary>
        public string PrimaryStrong { get; set; } = "#ee7625";

        /// <summary>
        /// The soft variant of the primary color.
        /// </summary>
        public string PrimarySoft { get; set; } = "#fedec8";

        /// <summary>
        /// The strong variant of the secondary color.
        /// </summary>
        public string SecondaryStrong { get; set; } = "#53b1fd";

        /// <summary>
        /// The soft variant of the secondary color.
        /// </summary>
        public string SecondarySoft { get; set; } = "#eff8ff";

        /// <summary>
        /// The strong variant of the brand color.
        /// </summary>
        public string BrandStrong { get; set; } = "#ee7625";

        /// <summary>
        /// The soft variant of the brand color.
        /// </summary>
        public string BrandSoft { get; set; } = "#fedec8";

        #endregion

        #region Functional Colors

        /// <summary>
        /// The strong variant of the success color.
        /// </summary>
        public string SuccessStrong { get; set; } = "#047857";

        /// <summary>
        /// The soft variant of the success color.
        /// </summary>
        public string SuccessSoft { get; set; } = "#d1fae5";

        /// <summary>
        /// The strong variant of the info color.
        /// </summary>
        public string InfoStrong { get; set; } = "#0369a1";

        /// <summary>
        /// The soft variant of the info color.
        /// </summary>
        public string InfoSoft { get; set; } = "#e0f2fe";

        /// <summary>
        /// The strong variant of the danger color.
        /// </summary>
        public string DangerStrong { get; set; } = "#b91c1c";

        /// <summary>
        /// The soft variant of the danger color.
        /// </summary>
        public string DangerSoft { get; set; } = "#fee2e2";

        /// <summary>
        /// The strong variant of the warning color.
        /// </summary>
        public string WarningStrong { get; set; } = "#b45309";

        /// <summary>
        /// The soft variant of the warning color.
        /// </summary>
        public string WarningSoft { get; set; } = "#fef3c7";

        #endregion
    }
}
