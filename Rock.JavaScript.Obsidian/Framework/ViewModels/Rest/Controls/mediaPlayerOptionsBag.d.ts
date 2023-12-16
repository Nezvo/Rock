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

import { Guid } from "@Obsidian/Types";

/**
 * The options that can be passed to the GetChildren API action of the AccountPicker control.
 * 
 * NOTE: This is copied from Rock/Media/MediaPlayerOptions.cs.
 * If making any changes to this, be sure to update that as well.
 */
export type MediaPlayerOptionsBag = {
    /**
     * Gets or sets a value indicating whether to automatically pause
     * other media players on the page when this player begins playing.
     */
    autopause: boolean;

    /**
     * Gets or sets a value indicating whether to attempt to automatically
     * play as soon as it can. This will likely only work if you also
     * specify the Rock.ViewModels.Rest.Controls.MediaPlayerOptionsBag.Muted parameter as most browsers do not
     * allow auto play with sound.
     */
    autoplay: boolean;

    /**
     * Gets or sets a value indicating whether the user will be allowed to
     * click anywhere on the media player to play or pause the playback.
     */
    clickToPlay: boolean;

    /**
     * Gets or sets the user interface controls to display on the player.
     * This should be a comma delimited list of values taken from MediaPlayerControls.
     */
    controls?: string | null;

    /**
     * Gets or sets a value indicating whether debug information should
     * be written to the JavaScript console.
     */
    debug: boolean;

    /**
     * Gets or sets a value indicating whether the user interface controls
     * should be automatically hidden after a brief period of inactivity.
     */
    hideControls: boolean;

    /**
     * Gets or sets the interaction unique identifier to be updated. If
     * not set then a new Interaction is created.
     */
    interactionGuid?: Guid | null;

    /**
     * Gets or sets the previous watch map data. This is used when
     * calculating the resume position or updating an existing Interaction.
     */
    map?: string | null;

    /**
     * Gets or sets the media element unique identifier. This is used when
     * writing an Interaction to associate it to the media element.
     */
    mediaElementGuid?: Guid | null;

    /** Gets or sets the URL to use for playback. */
    mediaUrl?: string | null;

    /**
     * Gets or sets a value indicating whether the media player will be
     * initially muted on page load.
     */
    muted: boolean;

    /**
     * Gets or sets the poster image URL to display before the video
     * starts playing. This only works with HTML5 style videos, it will
     * not work with embed links such as YouTube uses.
     */
    posterUrl?: string | null;

    /**
     * Gets or sets the related entity identifier to store with the
     * interaction if the session is being tracked.
     */
    relatedEntityId?: number | null;

    /**
     * Gets or sets the related entity type identifier to store with
     * the interaction if the session is being tracked.
     */
    relatedEntityTypeId?: number | null;

    /**
     * Gets or sets a value indicating whether to resume playback from
     * the first gap in playback history.
     */
    resumePlaying?: boolean | null;

    /**
     * Gets or sets the number of seconds to seek forward or backward
     * when the fast-forward or rewind controls are clicked.
     */
    seekTime: number;

    /** Gets or sets the unique identifier for the current interaction session. */
    sessionGuid?: Guid | null;

    /** Gets or sets the title to display for the video. */
    title?: string | null;

    /**
     * Gets or sets a value indicating whether progress tracking should be
     * enabled. This is different than Rock.ViewModels.Rest.Controls.MediaPlayerOptionsBag.WriteInteraction. This
     * value determines if the internal logic for monitoring playback
     * progress should be used or not. It is required for Rock.ViewModels.Rest.Controls.MediaPlayerOptionsBag.WriteInteraction
     * to function.
     */
    trackProgress: boolean;

    /** Gets or sets the type of media player to display. */
    type?: string | null;

    /** Gets or sets the initial volume for playback. */
    volume: number;

    /**
     * Determines if the user's session should be tracked and stored as an
     * Interaction in the system. This is required
     * to provide play metrics as well as use the resume feature later.
     */
    writeInteraction: boolean;
};
