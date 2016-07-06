using System;
using Bridge.jQuery2;

namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    public class HubProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public object State;

        /// <summary>
        /// 
        /// </summary>
        public HubConnection Connection;

        /// <summary>
        /// 
        /// </summary>
        public string HubName;

        private extern HubProxy();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public extern bool HasSubscriptions();

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T>(string eventName, Action<T> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T>(string eventName, Action<T> callback);

        /// <summary>Invokes a server hub method with the given arguments.</summary>
        /// <param name="methodName" type="String">The name of the server hub method.</param>
        /// <param name="parameters"></param>
        public extern Deferred Invoke(string methodName, params object[] parameters);

    }
}
