using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(TheBrewery.SignalR.Startup))]
namespace TheBrewery.SignalR
{
    public class Startup {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}