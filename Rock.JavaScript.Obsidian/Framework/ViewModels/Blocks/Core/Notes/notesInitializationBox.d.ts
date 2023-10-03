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

import { NoteBag } from "@Obsidian/ViewModels/Blocks/Core/Notes/noteBag";
import { NoteTypeBag } from "@Obsidian/ViewModels/Blocks/Core/Notes/noteTypeBag";

export type NotesInitializationBox = {
    /** Gets or sets a value indicating whether the add note editor should always be visible. */
    addAlwaysVisible: boolean;

    /** Gets or sets a value indicating whether the note type heading should be visible. */
    displayNoteTypeHeading: boolean;

    /** Gets or sets the identifier key of the context entity for this block. */
    entityIdKey?: string | null;

    /** Gets or sets the entity type identifier of the context entity for this block. */
    entityTypeIdKey?: string | null;

    /** Gets or sets the error message. */
    errorMessage?: string | null;

    /** Gets or sets a value indicating whether replies should be automatically expanded. */
    expandReplies: boolean;

    /** Gets or sets a value indicating whether notes should be displayed in descending order. */
    isDescending: boolean;

    /** Gets or sets a value indicating whether this block is in light mode. */
    isLightMode: boolean;

    /** Gets or sets the note label that describes a single note. */
    noteLabel?: string | null;

    /** Gets or sets the notes to display. */
    notes?: NoteBag[] | null;

    /** Gets or sets the note types configured on the block. */
    noteTypes?: NoteTypeBag[] | null;

    /** Gets or sets the avatar URL of the current person. */
    personAvatarUrl?: string | null;

    /** Gets or sets a value indicating whether adding notes is allowed. */
    showAdd: boolean;

    /** Gets or sets a value indicating whether the alert checkbox should be shown. */
    showAlertCheckBox: boolean;

    /** Gets or sets a value indicating whether the created date override should be visible. */
    showCreateDateInput: boolean;

    /** Gets or sets a value indicating whether private checkbox should be shown. */
    showPrivateCheckBox: boolean;

    /** Gets or sets a value indicating whether security button should be shown. */
    showSecurityButton: boolean;

    /** Gets or sets the panel title. */
    title?: string | null;

    /** Gets or sets the title icon CSS class. */
    titleIconCssClass?: string | null;

    /** Gets or sets a value indicating whether person icons should be shown. */
    usePersonIcon: boolean;
};
