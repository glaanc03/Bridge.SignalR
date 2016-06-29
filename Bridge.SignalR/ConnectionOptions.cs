using System;

namespace Bridge.SignalR
{
    [External]
    [ObjectLiteral]
    [Name("Object")]
    public class ConnectionOptions
    {
        public extern int PingInterval { get; set; }

        public extern bool WaitForPageLoad { get; set; }
                    
        public extern bool Jsonp { get; set; }
                    
        public extern TransportType[] Transport { get; set; }

        public extern bool WithCredentials { get; set; }

        public extern Action Callback { get; set; }
    }
}