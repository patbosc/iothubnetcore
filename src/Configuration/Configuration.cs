using System.Collections.Generic;

namespace Configuration
{
    /// <summary>
    /// Model of yaml configuration file.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Gets or sets the azure iot hub configuration.
        /// </summary>
        /// <value>
        /// The azure io t hub configuration.
        /// </value>
        public AzureIoTHubConfig AzureIoTHubConfig { get; set; }

        /// <summary>
        /// Gets or sets the list of device configurations.
        /// </summary>
        /// <value>
        /// The device configurations.
        /// </value>
        public List<DeviceConfiguration> DeviceConfigs { get; set; }
    }
}
