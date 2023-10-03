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

using System.Collections.Generic;

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Blocks.Core.Notes
{
    /// <summary>
    /// Describes a request to save changes to an existing note.
    /// </summary>
    public class SaveNoteRequestBag : IValidPropertiesBox
    {
        /// <summary>
        /// Gets or sets the bag that contains the changes that should be made to the note.
        /// </summary>
        /// <value>The bag that contains the changes that should be made to the note.</value>
        public NoteEditBag Bag { get; set; }

        /// <summary>
        /// Gets the valid properties of the <see cref="Bag"/>.
        /// </summary>
        /// <value>The valid properties of the <see cref="Bag"/>.</value>
        public List<string> ValidProperties { get; set; }
    }
}
