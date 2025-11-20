using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.ViewModels.Blocks.Finance.BenevolenceRequestDetail
{
    /// <summary>
    /// Represents the connection status information for a benevolence request.
    /// </summary>
    public class ConnectionStatusBag
    {
        /// <summary>
        /// Gets or sets the identifier of the connection status value.
        /// </summary>
        public int? ConnectionStatusValueId { get; set; }

        /// <summary>
        /// Gets or sets the name of the connection status.
        /// </summary>
        public string ConnectionStatusName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (GUID) of the connection status.
        /// </summary>
        public Guid ConnectionStatusGuid { get; set; }
    }
}
