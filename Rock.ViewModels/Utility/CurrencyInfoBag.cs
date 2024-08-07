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
namespace Rock.ViewModels.Utility
{
    /// <summary>
    /// Defines the attribute values of the Currency defined by the Organization Currency Code Global Attribute.
    /// </summary>
    public class CurrencyInfoBag
    {
        /// <summary>
        /// Gets or sets the symbol of the currency
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the number of decimal places that the currency needs to display
        /// </summary>
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// Gets or sets if the currency code needs to be displayed on the left or the right side.
        /// </summary>
        public string SymbolLocation { get; set; }
    }
}
