namespace Bridge.SignalR
{
    /// <summary>
    /// Bridge.SignalR Bindings used to get a connection to a Hub.
    /// </summary>
    [External]
    public class SignalR
    {
        private SignalR()
        {

        }

        /// <summary>
        /// Creates a new hub connection.
        /// </summary>
        /// <returns type="HubConnection">SignalR HubConnection</returns>
        [Template("$.hubConnection()")]
        public static extern HubConnection HubConnection();

        /// <summary>
        /// Creates a new hub connection.
        /// </summary>
        /// <param name="url" type="String">The hub route url, defaults to "/signalr".</param>
        /// <returns type="HubConnection">SignalR HubConnection</returns>
        [Template("$.hubConnection({0})")]
        public static extern HubConnection HubConnection(string url);

        /// <summary>
        /// Creates a new hub connection.
        /// </summary>
        /// <param name="url" type="String">[Optional] The hub route url, defaults to "/signalr".</param>
        /// <param name="options" type="HubSettings">
        /// [Optional] Settings to use when creating the hubConnection.
        /// </param>
        /// <returns type="HubConnection">SignalR HubConnection</returns>
        [Template("$.hubConnection({0},{1})")]
        public static extern HubConnection HubConnection(string url, HubSettings options);

        /// <summary>
        /// SignalR Version
        /// </summary>
        [Template("$.signalR.version")]
        public static string Version;
    }
}
