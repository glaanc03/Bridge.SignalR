namespace Bridge.SignalR
{
    /// <summary>
    /// SignalR HubSettings.
    /// </summary>
    [External]
    [ObjectLiteral]
    [Name("Object")]
    public class HubSettings
    {
        /// <summary>
        /// client-side logging. (default: false)
        /// </summary>
        public bool Logging;

        /// <summary>
        /// data send to the server when the client connects.
        /// </summary>
        [Name("qs")]
        public object QueryString;

        /// <summary>
        /// use default Path for the SignalR hub. (default: true)
        /// </summary>
        public bool UseDefaultPath;
    }
}
