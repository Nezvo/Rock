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
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using Rock.Communication;
using Rock.Data;
using Rock.Model;
using Rock.Web.Cache;

namespace Rock.ElectronicSignature
{
    /// <summary>
    /// Class ElectronicSignatureHelper.
    /// </summary>
    public static class ElectronicSignatureHelper
    {
        /// <summary>
        /// Sample Ted Decker signature data URL
        /// </summary>
        public const string SampleSignatureDataURL = @"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAsMAAAEbCAYAAAA/CYmdAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyZpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDcuMS1jMDAwIDc5LmVkYTJiM2ZhYywgMjAyMS8xMS8xNy0xNzoyMzoxOSAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIDIzLjEgKFdpbmRvd3MpIiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOjQ0MTY5OUQ4ODhFQzExRUNCNkJEQTQ2NzIzNzc2RTMwIiB4bXBNTTpEb2N1bWVudElEPSJ4bXAuZGlkOjQ0MTY5OUQ5ODhFQzExRUNCNkJEQTQ2NzIzNzc2RTMwIj4gPHhtcE1NOkRlcml2ZWRGcm9tIHN0UmVmOmluc3RhbmNlSUQ9InhtcC5paWQ6NDQxNjk5RDY4OEVDMTFFQ0I2QkRBNDY3MjM3NzZFMzAiIHN0UmVmOmRvY3VtZW50SUQ9InhtcC5kaWQ6NDQxNjk5RDc4OEVDMTFFQ0I2QkRBNDY3MjM3NzZFMzAiLz4gPC9yZGY6RGVzY3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz693c2JAAAzHklEQVR42uzd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";

        /// <summary>
        /// Gets the signature document HTML (prior to signing)
        /// </summary>
        /// <param name="lavaTemplate">The lava template.</param>
        /// <param name="mergeFields">The merge fields.</param>
        /// <returns>System.String.</returns>
        public static string GetSignatureDocumentHtml( string lavaTemplate, Dictionary<string, object> mergeFields )
        {
            return lavaTemplate.ResolveMergeFields( mergeFields );
        }

        /// <summary>
        /// Gets the signed document HTML.
        /// </summary>
        /// <param name="signatureDocumentHtml">The signature document HTML.</param>
        /// <param name="signatureInformation">The signature information.</param>
        /// <returns>System.String.</returns>
        public static string GetSignedDocumentHtml( string signatureDocumentHtml, string signatureInformation )
        {
            return signatureDocumentHtml + signatureInformation;
        }

        /// <summary>
        /// Gets the signature information HTML. This would be the HTML of the drawn or typed signature data
        /// </summary>
        /// <param name="signatureInformationHtmlArgs">The signature information HTML arguments.</param>
        /// <returns>System.String.</returns>
        public static string GetSignatureInformationHtml( GetSignatureInformationHtmlOptions signatureInformationHtmlArgs )
        {
            string signatureHtml;

            if ( signatureInformationHtmlArgs.SignatureType == SignatureType.Drawn )
            {
                signatureHtml = $@"<img src='{signatureInformationHtmlArgs.DrawnSignatureDataUrl}' class='signature-image' />";
            }
            else
            {
                signatureHtml = $@"<span class='signature-typed'> {signatureInformationHtmlArgs.SignedName} <span>";
            }

            var signatureInfoName = signatureInformationHtmlArgs.SignedName;
            if ( signatureInfoName.IsNullOrWhiteSpace() )
            {
                signatureInfoName = signatureInformationHtmlArgs.SignedByPerson?.FullName;
            }

            // NOTE that the Signature Document will be rendered as a PDF without any external styles, so we'll but the styles here.
            var signatureCss = @"
<style>
    .signature-container {
        background-color: #f5f5f5;
        border: #000000 solid 1px;
        padding: 10px;
        page-break-inside: avoid;
    }

    .signature-row {
        display: flex;
    }

    .signature-data {
        flex: auto;
    }

    .signature-image {
        width: 100%;
    }

    .signature-details {
        flex:auto;
        white-space: nowrap;
    }
    
    .signature-ref {
        text-align: right;
        font-family: 'Courier New', Courier, monospace;
        font-size: 11px
    }
</style>
";

            var signatureInformationHtml = $@"
{signatureCss}

<div class='signature-container'>
    <header class='signature-row'>
        <div class='col signature-data'>
            {signatureHtml}
        </div>
        <div class='col signature-details'>
            <div class='signature-fullname'>Name: {signatureInfoName}</div>
            <div class='signature-datetime'>Signed: {signatureInformationHtmlArgs.SignedDateTime.ToShortDateString()}</div>
            <div class='signature-ip-address'>IP: {signatureInformationHtmlArgs.SignedClientIp}</div>
        </div>
    </header>
    <div>
        <input type='checkbox' class='signature-checkbox' checked='true' /> <span class='signature-agreement'>I agree to
            the statements above and understand this is a legal representation of my signature.</span>
    </div>

    <p class='signature-ref'>ref: {signatureInformationHtmlArgs.SignatureVerificationHash}</p>
</div>
";

            return signatureInformationHtml;
        }

        /// <summary>
        /// Sends the signature completion communication if the SignatureDocument's <see cref="SignatureDocumentTemplate.CompletionSystemCommunication"/> is assigned.
        /// Note that if this is called and the there is no <see cref="SignatureDocumentTemplate.CompletionSystemCommunication"/>, this method will return true, even though
        /// there was no email sent.
        /// </summary>
        /// <param name="signatureDocumentId">The signature document identifier.</param>
        /// <param name="errorMessages">The error messages.</param>
        public static bool SendSignatureCompletionCommunication( int signatureDocumentId, out List<string> errorMessages )
        {
            errorMessages = new List<string>();
            var rockContext = new RockContext();
            var signatureDocument = new SignatureDocumentService( rockContext ).Queryable()
                .Where( a => a.Id == signatureDocumentId )
                .Include( s => s.SignatureDocumentTemplate.CompletionSystemCommunication )
                .Include( s => s.SignedByPersonAlias.Person )
                .Include( s => s.BinaryFile )
                .FirstOrDefault();

            var completionSystemCommunication = signatureDocument.SignatureDocumentTemplate?.CompletionSystemCommunication;

            if ( completionSystemCommunication == null )
            {
                /* MP 02/08/2022

                If no completionSystemCommunication is configured, and this method is called,
                return true even though an email doesn't end up getting sent.
                We'll only return false if there are errors sending the email.

                */
                return true;
            }

            var mergeFields = Rock.Lava.LavaHelper.GetCommonMergeFields( null );
            mergeFields.Add( "SignatureDocument", signatureDocument );

            if ( signatureDocument.EntityTypeId.HasValue && signatureDocument.EntityId.HasValue )
            {
                var entityTypeType = EntityTypeCache.Get( signatureDocument.EntityTypeId.Value )?.GetEntityType();
                var entity = Reflection.GetIEntityForEntityType( entityTypeType, signatureDocument.EntityId.Value );
                mergeFields.Add( "Entity", entity );
            }

            var signedByPerson = signatureDocument.SignedByPersonAlias?.Person;
            var signedByEmail = signatureDocument.SignedByEmail;
            var pdfFile = signatureDocument.BinaryFile;

            var emailMessage = new RockEmailMessage( completionSystemCommunication );
            RockEmailMessageRecipient rockEmailMessageRecipient;
            if ( signedByPerson.Email.Equals( signedByEmail, StringComparison.OrdinalIgnoreCase ) )
            {
                // if they specified the same email they already have, send it as a normal email message
                rockEmailMessageRecipient = new RockEmailMessageRecipient( signedByPerson, mergeFields );
            }
            else
            {
                // if they selected a different email address, don't change their email address. Just send to the specified email address.
                rockEmailMessageRecipient = RockEmailMessageRecipient.CreateAnonymous( signedByEmail, mergeFields );
            }

            emailMessage.Attachments.Add( pdfFile );

            emailMessage.AddRecipient( rockEmailMessageRecipient );

            // errors will be logged by send
            var successfullySent = emailMessage.Send( out errorMessages );
            if ( successfullySent )
            {
                signatureDocument.CompletionEmailSentDateTime = RockDateTime.Now;
                rockContext.SaveChanges();
            }

            return successfullySent;
        }
    }
}
