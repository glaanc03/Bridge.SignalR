namespace Bridge.SignalR
{
    /// <summary>
    /// SignalR Transport Types
    /// </summary>
    [External]
    [Enum(Emit.StringName)]
    [Name("String")]
    public enum TransportType
    {
        /// <summary>
        /// Represents a transport based on web socket.
        /// </summary>
        WebSockets,

        /// <summary>
        /// Represents a transport based on forever frame.
        /// </summary>
        ForeverFrame,

        /// <summary>
        /// Represents a HTTP based transport used for server sent events.
        /// </summary>
        ServerSentEvents,

        /// <summary>
        /// Represents a transport based on long polling.
        /// </summary>
        LongPolling
    }
}
