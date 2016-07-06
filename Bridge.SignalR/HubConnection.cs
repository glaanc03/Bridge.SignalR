using System;
using Bridge.jQuery2;

namespace Bridge.SignalR
{
    /// <summary>
    /// 
    /// </summary>
    [External]
    public class HubConnection
    {

        private extern HubConnection();

        /// <summary>
        /// 
        /// </summary>
        public bool Logging;

        /// <summary>
        /// 
        /// </summary>
        public Guid Id;

        /// <summary>
        /// 
        /// </summary>
        public string MessageId;

        /// <summary>
        /// 
        /// </summary>
        public readonly ConnectionState State;

        /// <summary>
        /// 
        /// </summary>
        [Name("qs")]
        public dynamic QueryString;

        /// <summary>
        ///     Creates a new proxy object for the given hub connection that can be used to invoke
        ///     methods on server hubs and handle client method invocation requests from the server.
        /// </summary>
        /// <param name="hubName" type="String">
        ///     The name of the hub on the server to create the proxy for.
        /// </param>
        public extern HubProxy CreateHubProxy(string hubName);

        /// <summary>Checks if url is cross domain</summary>
        /// <param name="url" type="String">The base URL</param>
        /// <param name="against" type="Object">
        ///     An optional argument to compare the URL against, if not specified it will be set to window.location.
        ///     If specified it must contain a protocol and a host property.
        /// </param>
        public extern bool IsCrossDomain(string url, object against = null);


        /// <summary>Starts the connection</summary>
        public extern Deferred Start();

        /// <summary>Starts the connection</summary>
        /// <param name="options" type="Object">Options map</param>
        public extern Deferred Start(ConnectionOptions options);

        /// <summary>Starts the connection</summary>
        /// <param name="callback" type="Function">A callback function to execute when the connection has started</param>
        public extern Deferred Start(Action callback);

        /// <summary>Starts the connection</summary>
        /// <param name="options" type="Object">Options map</param>
        /// <param name="callback" type="Function">A callback function to execute when the connection has started</param>
        public extern Deferred Start(ConnectionOptions options, Action callback);

        /// <summary>Stops listening</summary>
        /// <returns type="HubConnection" />
        public extern HubConnection Stop();

        /// <summary>Stops listening</summary>
        /// <param name="async" type="Boolean">Whether or not to asynchronously abort the connection</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Stop(bool async);

        /// <summary>Stops listening</summary>
        /// <param name="async" type="Boolean">Whether or not to asynchronously abort the connection</param>
        /// <param name="notifyServer" type="Boolean">Whether we want to notify the server that we are aborting the connection</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Stop(bool async, bool notifyServer);

        /// <summary>Adds a callback that will be invoked before anything is sent over the connection</summary>
        /// <param name="callback" type="Function">A callback function to execute before the connection is fully instantiated.</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Starting(Action callback);

        /// <summary>Sends data over the connection</summary>
        /// <param name="data" type="String">The data to send over the connection</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Send(string data);

        /// <summary>Adds a callback that will be invoked after anything is received over the connection</summary>
        /// <param name="callback" type="Function">A callback function to execute when any data is received on the connection</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Received(Action<object> callback);

        /// <summary>Adds a callback that will be invoked when the connection state changes</summary>
        /// <param name="callback" type="Function">A callback function to execute when the connection state changes</param>
        /// <returns type="HubConnection" />
        public extern HubConnection StateChanged(Action<StateChange> callback);

        /// <summary>Adds a callback that will be invoked after an error occurs with the connection</summary>
        /// <param name="callback" type="Function">A callback function to execute when an error occurs on the connection</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Error(Action<string> callback);

        /// <summary>Adds a callback that will be invoked when the client disconnects</summary>
        /// <param name="callback" type="Function">A callback function to execute when the connection is broken</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Disconnected(Action callback);

        /// <summary>Adds a callback that will be invoked when the client detects a slow connection</summary>
        /// <param name="callback" type="Function">A callback function to execute when the connection is slow</param>
        /// <returns type="HubConnection" />
        public extern HubConnection ConnectionSlow(Action callback);

        /// <summary>Adds a callback that will be invoked when the underlying transport begins reconnecting</summary>
        /// <param name="callback" type="Function">A callback function to execute when the connection enters a reconnecting state</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Reconnecting(Action callback);

        /// <summary>Adds a callback that will be invoked when the underlying transport reconnects</summary>
        /// <param name="callback" type="Function">A callback function to execute when the connection is restored</param>
        /// <returns type="HubConnection" />
        public extern HubConnection Reconnected(Action callback);
    }
}
