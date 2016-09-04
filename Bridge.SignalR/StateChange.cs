namespace Bridge.SignalR
{
    /// <summary>
    /// Represents a change in the connection state.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StateChange
    {
        /// <summary>
        /// The new state of the connection.
        /// </summary>
        public ConnectionState OldState { get; set; }

        /// <summary>
        /// The old state of the connection.
        /// </summary>
        public ConnectionState NewState { get; set; }
    }
}
