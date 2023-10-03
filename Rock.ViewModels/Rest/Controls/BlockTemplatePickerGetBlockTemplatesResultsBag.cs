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
using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Rest.Controls
{
    /// <summary>
    /// The results from the GetBlockTemplates API action of the BlockTemplatePicker control.
    /// </summary>
    public class BlockTemplatePickerGetBlockTemplatesResultsBag
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Guid{ get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Template { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string IconUrl { get; set; }
    }
}
