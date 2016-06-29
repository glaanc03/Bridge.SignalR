namespace Bridge.SignalR
{
    [External]
    public class SignalR
    {
        private SignalR()
        {

        }

        [Template("$.hubConnection()")]
        public static extern HubConnection HubConnection();

        [Template("$.hubConnection({0})")]
        public static extern HubConnection HubConnection(string url);

        [Template("$.signalR.version")]
        public static string Version;
    }
}
