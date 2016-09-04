namespace Bridge.SignalR
{
    /// <summary>
    /// Represents a connection state of a SignalR connection.
    /// </summary>
    [External]
    [Enum(Emit.Value)]
    public enum ConnectionState
    {
        /// <summary>
        /// The connection state is connecting.
        /// </summary>
        Connecting = 0,

        /// <summary>
        /// The connection state is connected.
        /// </summary>
        Connected = 1,

        /// <summary>
        /// The connection state is reconnecting.
        /// </summary>
        Reconnecting = 2,

        /// <summary>
        /// The connection state is disconnected.
        /// </summary>
        Disconnected = 4
    }
}
