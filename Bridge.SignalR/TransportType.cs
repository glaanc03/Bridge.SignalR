namespace Bridge.SignalR
{
    [External]
    [Enum(Emit.StringName)]
    [Name("String")]
    public enum TransportType
    {
        WebSockets,
        ForeverFrame,
        ServerSentEvents,
        LongPolling
    }
}
