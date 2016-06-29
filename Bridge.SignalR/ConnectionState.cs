namespace Bridge.SignalR
{
    [External]
    [Enum(Emit.Value)]
    public enum ConnectionState
    {
        Connecting = 0,
        Connected = 1,
        Reconnecting = 2,
        Disconnected = 4
    }
}
