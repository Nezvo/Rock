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

import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

/** AchievementType View Model */
export type AchievementTypeBag = {
    /** Gets or sets the Id of the Rock.Model.WorkflowType to be triggered when an achievement is failed (closed and not successful) */
    achievementFailureWorkflowTypeId?: number | null;

    /** Gets or sets the icon CSS class. */
    achievementIconCssClass?: string | null;

    /** Gets or sets the Id of the Rock.Model.WorkflowType to be triggered when an achievement is started */
    achievementStartWorkflowTypeId?: number | null;

    /** Gets or sets the Id of the Rock.Model.StepStatus of which a Rock.Model.Step will be created when an achievement is completed */
    achievementStepStatusId?: number | null;

    /** Gets or sets the Id of the Rock.Model.StepType of which a Rock.Model.Step will be created when an achievement is completed */
    achievementStepTypeId?: number | null;

    /** Gets or sets the Id of the Rock.Model.WorkflowType to be triggered when an achievement is successful */
    achievementSuccessWorkflowTypeId?: number | null;

    /**
     * Gets or sets the achiever entity type. The achiever is the object that earns the achievement.
     * The original achiever was a Rock.Model.PersonAlias via Rock.Model.Streak.PersonAliasId.
     */
    achieverEntityTypeId: number;

    /** Gets or sets whether over achievement is allowed. This cannot be true if Rock.Model.AchievementType.MaxAccomplishmentsAllowed is greater than 1. */
    allowOverAchievement: boolean;

    /** An alternate image that can be used for custom purposes. */
    alternateImageBinaryFileId?: number | null;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the lava template used to render a badge. */
    badgeLavaTemplate?: string | null;

    /** Gets or sets the Rock.Model.Category identifier. */
    categoryId?: number | null;

    /** Gets or sets the configuration from the Rock.Model.AchievementType.ComponentEntityTypeId. */
    componentConfigJson?: string | null;

    /** Gets or sets the Id of the achievement component Rock.Model.EntityType */
    componentEntityTypeId: number;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets the lava template used to render the status summary of the achievement. */
    customSummaryLavaTemplate?: string | null;

    /** Gets or sets a description of the achievement type. */
    description?: string | null;

    /** Gets or sets the color of the highlight. */
    highlightColor?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /**
     * Gets or sets the image binary file identifier. This would be the image
     * that would be shown in the achievement summary (for example, a trophy).
     */
    imageBinaryFileId?: number | null;

    /** Gets a value indicating whether this instance is active. */
    isActive: boolean;

    /** Gets or sets a value indicating whether this instance is public. */
    isPublic: boolean;

    /** Gets or sets the maximum accomplishments allowed. */
    maxAccomplishmentsAllowed?: number | null;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the name of the achievement type. This property is required. */
    name?: string | null;

    /** Gets or sets the lava template used to render results. */
    resultsLavaTemplate?: string | null;

    /**
     * Gets or sets the source entity type. The source supplies the data framework from which achievements are computed.
     * The original achievement sources were Streaks.
     */
    sourceEntityTypeId?: number | null;
};
