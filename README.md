# Bridge.SignalR

[Bridge.NET](http://bridge.net/) Bindings for SignalR - write JavaScript applications in C#!

## Sample

This following sample was basicly taken from the [Getting Started with SignalR 2 and MVC 5 tutorial](http://www.asp.net/signalr/overview/getting-started/tutorial-getting-started-with-signalr-and-mvc). It only covers the Brige.net (client) part as it should only demonstrate how to use Bridge.SignalR. Because of the usage of a massage model I also provide the hub code.

```csharp
using Bridge.Html5;
using Bridge.jQuery2;
using Bridge.SignalR;
using SignalRJsSample.Models;

namespace SignalRJsSample
{
    public class App
    {
        [Ready]
        public static void Main()
        {
            HubConnection connection = SignalR.HubConnection();
            HubProxy chatProxy = connection.CreateHubProxy("chatHub");

            chatProxy.On<MessageModel>("addNewMessageToPage", data =>
            {
                jQuery.Select("#discussion").Append("<li><strong>" +
                    data.Name + "</strong>: " + data.Message + "</li>");
            });

            var name = Window.Prompt("Enter your name:", "");

            var inputElement = jQuery.Select("#message");
            inputElement.Focus();

            connection.Start().Done(() =>
            {
                jQuery.Select("#discussion").Append(new HTMLDivElement
                {
                    InnerHTML = "Connected"
                });

                jQuery.Select("#sendmessage").Click(evt =>
                {
                    chatProxy.Invoke("send", name, inputElement.Val());
                    inputElement.Val("").Focus();
                });

            }).Fail(() =>
            {
                jQuery.Select("#discussion").Append(new HTMLDivElement
                {
                    InnerHTML = "SignalR start failed"
                });
            });
        }
    }
}
```

The Server Hub looks like this

```csharp
using Microsoft.AspNet.SignalR;
using SignalRWebSample.Models;

namespace SignalRWebSample.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            var msg = new MessageModel { Name = name, Message = message };
            Clients.All.addNewMessageToPage(msg);
        }
    }
}
```
