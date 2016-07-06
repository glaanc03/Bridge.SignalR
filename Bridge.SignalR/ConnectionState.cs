namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    [Enum(Emit.Value)]
    public enum ConnectionState
    {
        /// <summary>
        /// 
        /// </summary>
        Connecting = 0,

        /// <summary>
        /// 
        /// </summary>
        Connected = 1,

        /// <summary>
        /// 
        /// </summary>
        Reconnecting = 2,

        /// <summary>
        /// 
        /// </summary>
        Disconnected = 4
    }
}
