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

using Rock.Model;
using Rock.SystemGuid;

namespace Rock.Rest.Controllers
{
    /// <summary>
    /// LearningGradingSystemScales REST API
    /// </summary>
    [RestControllerGuid( "CA8B8E20-BCAE-447D-B999-DA80FC6B52FD" )]
    public partial class LearningGradingSystemScalesController : Rock.Rest.ApiController<Rock.Model.LearningGradingSystemScale>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningGradingSystemScalesController"/> class.
        /// </summary>
        public LearningGradingSystemScalesController() : base( new Rock.Model.LearningGradingSystemScaleService( new Rock.Data.RockContext() ) ) { } 
    }
}
