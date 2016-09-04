using System;
using Bridge.jQuery2;

namespace Bridge.SignalR
{
    /// <summary>
    /// A client side proxy for a server side hub.
    /// </summary>
    [External]
    public class HubProxy
    {
        /// <summary>
        /// State of the Connection
        /// </summary>
        public object State;

        /// <summary>
        /// HubConnection used by the HubProxy
        /// </summary>
        public HubConnection Connection;

        /// <summary>
        /// Name of the Hub
        /// </summary>
        public string HubName;

        private extern HubProxy();

        /// <summary>
        /// Checks for registered event on the Hub. 
        /// </summary>
        /// <returns>Returns true if there is any registered event on the Hub.</returns>
        public extern bool HasSubscriptions();

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T>(string eventName, Action<T> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2>(string eventName, Action<T1, T2> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3>(string eventName, Action<T1, T2, T3> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback);

        /// <summary>Wires up a callback to be invoked when a invocation request is received from the server hub.</summary>
        /// <param name="eventName" type="String">The name of the hub event to register the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T>(string eventName, Action<T> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2>(string eventName, Action<T1, T2> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy OOffn<T1, T2, T3>(string eventName, Action<T1, T2, T3> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback);

        /// <summary>Removes the callback invocation request from the server hub for the given event name.</summary>
        /// <param name="eventName" type="String">The name of the hub event to unregister the callback for.</param>
        /// <param name="callback" type="Function">The callback to be invoked.</param>
        public extern HubProxy Off<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback);

        /// <summary>Invokes a server hub method with the given arguments.</summary>
        /// <param name="methodName" type="String">The name of the server hub method.</param>
        /// <param name="parameters"></param>
        public extern Deferred Invoke(string methodName, params object[] parameters);

    }
}
