namespace Configuration
{
    /// <summary>
    /// Model of settings of Azure IoT Hub.
    /// </summary>
    public class AzureIoTHubConfig
    {
        /// <summary>
        /// Gets or sets the iot hub URI - aka azure portal iot hub host name.
        /// </summary>
        /// <value>
        /// The iot hub URI - aka azure portal iot hub host name.
        /// </value>
        public string IoTHubUri { get; set; }

        /// <summary>
        /// Gets or sets the iot hub storage URI.
        /// </summary>
        /// <value>
        /// The iot hub storage URI.d
        /// </value>
        public string IoTHubStorageUri { get; set; }

        /// <summary>
        /// Gets or sets the io t hub storage container.
        /// </summary>
        /// <value>
        /// The io t hub storage container.
        /// </value>
        public string IoTHubStorageContainer { get; set; }

        /// <summary>
        /// Gets or sets the iot hub D2C (device to cloud) messaging endpoint.
        /// </summary>
        /// <value>
        /// The iot hub D2C (device to client) messaging endpoint.
        /// </value>
        public string IoTHubD2CEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the connection string to the iot hub.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; set; }
    }

}
