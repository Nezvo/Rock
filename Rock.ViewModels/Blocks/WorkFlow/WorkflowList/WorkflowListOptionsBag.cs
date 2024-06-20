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

namespace Rock.ViewModels.Blocks.Workflow.WorkflowList
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkflowListOptionsBag
    {
        /// <summary>
        /// Gets or sets a value indicating whether the current user can view the workflow.
        /// </summary>
        /// <value>
        ///   <c>true</c> if user can view the workflow<c>false</c>.
        /// </value>
        public bool CanView { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the workflow id column should be visible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the workflow id column should be visible; otherwise, <c>false</c>.
        /// </value>
        public bool IsWorkflowIdColumnVisible { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the grid should be visible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the grid should be visible; otherwise, <c>false</c>.
        /// </value>
        public bool IsGridVisible { get; set; }

        /// <summary>
        /// Gets or sets the item term.
        /// </summary>
        /// <value>
        /// The item term.
        /// </value>
        public string ItemTerm { get; set; }

        /// <summary>
        /// Gets or sets the workflow type identifier key.
        /// </summary>
        /// <value>
        /// The workflow type identifier key.
        /// </value>
        public string WorkflowTypeIdKey { get; set; }
    }
}
