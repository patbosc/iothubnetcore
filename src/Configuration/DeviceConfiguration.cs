namespace Configuration
{
    /// <summary>
    /// Model of a single device configuration.
    /// </summary>
    public class DeviceConfiguration
    {
        /// <summary>
        /// Gets or sets the name of the device nickname.
        /// </summary>
        /// <value>
        /// The name of the device nickname.
        /// </value>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the device identifier.
        /// </summary>
        /// <value>
        /// The device identifier.
        /// </value>
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the device key.
        /// </summary>
        /// <value>
        /// The device key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the device generation.
        /// </summary>
        /// <value>
        /// The generation.
        /// </value>
        public string Status { get; set; }
    }
}
