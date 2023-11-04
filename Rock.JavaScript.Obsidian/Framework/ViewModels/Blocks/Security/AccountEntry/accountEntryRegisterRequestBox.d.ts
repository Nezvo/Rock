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

import { AccountEntryAccountInfoBag } from "@Obsidian/ViewModels/Blocks/Security/AccountEntry/accountEntryAccountInfoBag";
import { AccountEntryPersonInfoBag } from "@Obsidian/ViewModels/Blocks/Security/AccountEntry/accountEntryPersonInfoBag";

/** A bag that contains the register request information. */
export type AccountEntryRegisterRequestBox = {
    /** Gets or sets the account info. */
    accountInfo?: AccountEntryAccountInfoBag | null;

    /** Gets or sets the passwordless verification code. */
    code?: string | null;

    /** Gets or sets a value indicating whether the solved captcha is valid. */
    isCaptchaValid: boolean;

    /** Gets or sets the person info. */
    personInfo?: AccountEntryPersonInfoBag | null;

    /** Gets or sets the selected Person identifier. */
    selectedPersonId?: number | null;

    /** Gets or sets the encrypted state. */
    state?: string | null;
};
