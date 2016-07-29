using System;

namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    [ObjectLiteral]
    [Name("Object")]
    public class ConnectionOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public extern int PingInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public extern bool WaitForPageLoad { get; set; }
                    
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public extern Action Callback { get; set; }
    }
}