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

/** The status of a signature document */
export const enum SignatureDocumentStatus {
    /** Document has not yet been sent */
    None = 0,

    /** Document has been sent but not yet signed */
    Sent = 1,

    /** Document has been signed */
    Signed = 2,

    /** Document was cancelled */
    Cancelled = 3,

    /** Document Invite had expired */
    Expired = 4
}
