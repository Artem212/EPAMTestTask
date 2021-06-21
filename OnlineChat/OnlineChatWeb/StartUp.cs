using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineChatWeb.Startup))]
namespace OnlineChatWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                   
                };
                map.RunSignalR(hubConfiguration);
            });
        }
    }

}