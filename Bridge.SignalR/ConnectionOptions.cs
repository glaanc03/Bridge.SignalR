using System;

namespace Bridge.SignalR
{
    /// <summary>
    /// Represents the SignalR ConnectionOption object
    /// </summary>
    [External]
    [ObjectLiteral]
    [Name("Object")]
    public class ConnectionOptions
    {
        /// <summary>
        /// PingInterval. (default: 300000)
        /// </summary>
        public extern int PingInterval { get; set; }

        /// <summary>
        /// If start is being called prior to page load and waitForPageLoad is
        /// true the call of start is re-direct to the window load event.
        /// (default: true)
        /// </summary>
        public extern bool WaitForPageLoad { get; set; }

        /// <summary>
        /// If set to true, Jsonp will be used. (default: false)
        /// </summary>
        public extern bool Jsonp { get; set; }
                    
        /// <summary>
        /// allowed transport types.
        /// </summary>
        public extern TransportType[] Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public extern bool WithCredentials { get; set; }

        /// <summary>
        /// A callback function to execute when the connection has started
        /// </summary>
        public extern Action Callback { get; set; }
    }
}