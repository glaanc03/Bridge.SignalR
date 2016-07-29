namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    public class SignalR
    {
        private SignalR()
        {

        }

        /// <summary>Creates a new hub connection.</summary>
        /// <returns></returns>
        [Template("$.hubConnection()")]
        public static extern HubConnection HubConnection();

        /// <summary>Creates a new hub connection.</summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [Template("$.hubConnection({0})")]
        public static extern HubConnection HubConnection(string url);

        /// <summary>Creates a new hub connection.</summary>
        /// <param name="url" type="String">[Optional] The hub route url, defaults to "/signalr".</param>
        /// <param name="options" type="HubSettings">[Optional] Settings to use when creating the hubConnection.</param>
        [Template("$.hubConnection({0},{1})")]
        public static extern HubConnection HubConnection(string url, HubSettings options);

        /// <summary>
        /// 
        /// </summary>
        [Template("$.signalR.version")]
        public static string Version;
    }
}
