using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(SignalRChatHost.StartUp))]
namespace SignalRChatHost
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration();
            config.EnableJSONP = true;
            app.MapSignalR(config);
        }
    }
    
}