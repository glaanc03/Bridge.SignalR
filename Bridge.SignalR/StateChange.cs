namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StateChange
    {
        /// <summary>
        /// 
        /// </summary>
        public ConnectionState OldState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ConnectionState NewState { get; set; }
    }
}
