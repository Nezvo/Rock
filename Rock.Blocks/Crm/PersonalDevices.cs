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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Rock;
using Rock.Model;
using Rock.Attribute;
using Rock.Web.UI;
using System.Data.Entity;
using Rock.ViewModels.Blocks.Crm.PersonalDevices;
using Rock.Web.Cache;

namespace Rock.Blocks.Crm
{
    [DisplayName( "Personal Devices" )]
    [Category( "CRM" )]
    [Description( "Shows a list of all personal devices." )]

    [LinkedPage(
        "Interactions Page",
        Key = NavigationUrlKey.InteractionsPage,
        Description = "The interactions associated with a specific personal device.",
        Order = 0 )]

    [ContextAware( typeof( Person ) )]
    [Rock.SystemGuid.BlockTypeGuid( "9A504904-8AF6-4351-AE31-CBC4DB2F55BA" )]
    public class PersonalDevices : RockBlockType
    {
        #region Keys

        private static class PageParameterKey
        {
            public const string PersonId = "PersonId";
        }

        private static class NavigationUrlKey
        {
            public const string InteractionsPage = "InteractionsPage";
        }

        #endregion Keys

        #region Methods

        public override object GetObsidianBlockInitialization()
        {
            var box = new PersonalDevicesBag();

            var personalDevices = GetPersonalDevices();

            var items = personalDevices.Select( pd => new PersonalDeviceListItemBag
            {
                Name = pd.Name,
                IsActive = pd.IsActive,
                MacAddress = pd.MACAddress,
                NotificationsEnabled = pd.NotificationsEnabled,
                LocationPermissionStatus = pd.LocationPermissionStatus,
                IsPreciseLocationEnabled = pd.IsPreciseLocationEnabled,
                IsBeaconMonitoringEnabled = pd.IsBeaconMonitoringEnabled,
                CreatedDateTime = pd.CreatedDateTime,
                LastSeenDateTime = pd.LastSeenDateTime,
            } ).ToList();

            box.PersonalDevices = items;

            box.NavigationUrls = GetBoxNavigationUrls();

            return box;
        }

        private List<PersonalDevice> GetPersonalDevices()
        {
            var person = this.RequestContext.GetContextEntity<Person>();
            int? personId = person?.Id;

            if ( !personId.HasValue )
            {
                var key = PageParameter( PageParameterKey.PersonId );
                if ( key.IsNotNullOrWhiteSpace() )
                {
                    var personFromKey = new PersonService( RockContext ).Get( key, !PageCache.Layout.Site.DisablePredictableIds );
                    personId = personFromKey?.Id;
                }
            }

            if ( !personId.HasValue )
            {
                return new List<PersonalDevice>();
            }

            var personalDeviceService = new PersonalDeviceService( RockContext );

            return personalDeviceService
                .Queryable()
                .AsNoTracking()
                .Where( pd => pd.PersonAlias != null && pd.PersonAlias.PersonId == personId.Value )
                .ToList();
        }

        /// <summary>
        /// Gets the box navigation URLs required for the page to operate.
        /// </summary>
        /// <returns>A dictionary of key names and URL values.</returns>
        private Dictionary<string, string> GetBoxNavigationUrls()
        {
            return new Dictionary<string, string>
            {
                [NavigationUrlKey.InteractionsPage] = this.GetLinkedPageUrl( NavigationUrlKey.InteractionsPage )
            };
        }

        #endregion Methods

        #region Block Actions

        public BlockActionResult DeletePersonalDevice( string key )
        {
            return ActionBadRequest( "Not authorized to delete this personal device." );
        }

        #endregion Block Actions
    }
}
