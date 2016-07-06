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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Template("$.hubConnection()")]
        public static extern HubConnection HubConnection();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [Template("$.hubConnection({0})")]
        public static extern HubConnection HubConnection(string url);

        /// <summary>
        /// 
        /// </summary>
        [Template("$.signalR.version")]
        public static string Version;
    }
}
