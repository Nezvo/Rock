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

import { AbilityLevelDeterminationMode } from "@Obsidian/Enums/CheckIn/abilityLevelDeterminationMode";
import { FamilySearchMode } from "@Obsidian/Enums/CheckIn/familySearchMode";
import { KioskCheckInMode } from "@Obsidian/Enums/CheckIn/kioskCheckInMode";
import { PhoneSearchMode } from "@Obsidian/Enums/CheckIn/phoneSearchMode";

/** The summary information about a single check-in configuration template. */
export type ConfigurationTemplateBag = {
    /**
     * Gets a value that determines how check-in should gather the
     * ability level of the current individual.
     */
    abilityLevelDetermination: AbilityLevelDeterminationMode;

    /**
     * Gets or sets the type of the family search configured for
     * the configuration.
     */
    familySearchType: FamilySearchMode;

    /** Gets or sets the icon CSS class defined on the check-in configuration. */
    iconCssClass?: string | null;

    /**
     * Gets or sets the identifier of this check-in configuration
     * template.
     */
    id?: string | null;

    /**
     * Gets or sets a value indicating whether auto-select mode is enabled
     * for this template. In auto-select mode all the selected information
     * is displayed on the person select screen with an optional button to
     * change those selections.
     */
    isAutoSelect: boolean;

    /**
     * Gets or sets a value indicating whether to allow self-checkout on
     * public kiosks for this configuration. When enabled, if an individual
     * in the family is already checked in then the kiosk will prompt if
     * they want to check-in another family member of checkout existing
     * individuals.
     */
    isCheckoutAtKioskAllowed: boolean;

    /**
     * Gets a value indicating whether the current location occupancy
     * counts should be displayed when selecting a location.
     */
    isLocationCountDisplayed: boolean;

    /**
     * Gets a value indicating whether an override option is available in
     * the kiosk supervisor screen. This allows an authorized support
     * person to bypass check-in requirements.
     */
    isOverrideAvailable: boolean;

    /**
     * Gets a value indicating whether individual photos should be hidden
     * on public kiosks.
     */
    isPhotoHidden: boolean;

    /**
     * Gets a value indicating whether the supervisor screen is available
     * to kiosks after entering a pin number.
     */
    isSupervisorEnabled: boolean;

    /**
     * Gets the type of check-in experience to use. Family check-in allows
     * more than one person in the family to be checked in at a time.
     */
    kioskCheckInType: KioskCheckInMode;

    /**
     * Gets or sets the maximum length of the phone number during
     * family search.
     */
    maximumPhoneNumberLength?: number | null;

    /**
     * Gets or sets the minimum length of the phone number during
     * family search.
     */
    minimumPhoneNumberLength?: number | null;

    /** Gets or sets the name of this check-in configuration. */
    name?: string | null;

    /** Gets or sets the type of the phone search used in family search. */
    phoneSearchType: PhoneSearchMode;
};
