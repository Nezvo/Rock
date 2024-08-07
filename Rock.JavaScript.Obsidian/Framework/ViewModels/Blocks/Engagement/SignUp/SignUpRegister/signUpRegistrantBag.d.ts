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

/** Information about a sign-up registrant. */
export type SignUpRegistrantBag = {
    /** Gets or sets whether to allow SMS messages to be sent to the registrant's mobile phone. */
    allowSms: boolean;

    /** Gets or sets the registrant's communication preference. */
    communicationPreference: number;

    /** Gets or sets the registrant's email. */
    email?: string | null;

    /** Gets or sets the registrant's first name. */
    firstName?: string | null;

    /** Gets or sets the registrant's full name. */
    fullName?: string | null;

    /** Gets or sets whether this Rock.ViewModels.Blocks.Engagement.SignUp.SignUpRegister.SignUpRegistrantBag instance represents a child. */
    isChild: boolean;

    /** Gets or sets whether this Rock.ViewModels.Blocks.Engagement.SignUp.SignUpRegister.SignUpRegistrantBag instance represents the registrar. */
    isRegistrar: boolean;

    /** Gets or sets the registrant's last name. */
    lastName?: string | null;

    /** Gets or sets the registrant's member attribute values. */
    memberAttributeValues?: Record<string, string> | null;

    /** Gets or sets the registrant's member opportunity attribute values. */
    memberOpportunityAttributeValues?: Record<string, string> | null;

    /** Gets or sets the registrant's mobile phone country code. */
    mobilePhoneCountryCode?: string | null;

    /** Gets or sets the registrant's mobile phone number. */
    mobilePhoneNumber?: string | null;

    /** Gets or sets the registrant's formatted mobile phone number. */
    mobilePhoneNumberFormatted?: string | null;

    /** Gets or sets the registrant's hashed person identifier key. */
    personIdKey?: string | null;

    /** Gets or sets the registrant's unmet group requirements, if any. */
    unmetGroupRequirements?: string[] | null;

    /** Gets or sets whether the registrant will attend. */
    willAttend: boolean;
};
