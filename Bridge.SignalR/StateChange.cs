namespace Bridge.SignalR
{
    [External]
    [ObjectLiteral]
    public class StateChange
    {
        public ConnectionState OldState { get; set; }
        public ConnectionState NewState { get; set; }
    }
}
