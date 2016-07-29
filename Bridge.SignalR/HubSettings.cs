namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    [ObjectLiteral]
    [Name("Object")]
    public class HubSettings
    {
        /// <summary>
        /// client-side logging.
        /// </summary>
        public bool Logging;

        /// <summary>
        /// data send to the server when the client connects.
        /// </summary>
        [Name("qs")]
        public dynamic QueryString;

        /// <summary>
        /// 
        /// </summary>
        public bool UseDefaultPath;
    }
}
