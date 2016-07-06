namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    [Enum(Emit.StringName)]
    [Name("String")]
    public enum TransportType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSockets,

        /// <summary>
        /// 
        /// </summary>
        ForeverFrame,

        /// <summary>
        /// 
        /// </summary>
        ServerSentEvents,

        /// <summary>
        /// 
        /// </summary>
        LongPolling
    }
}
