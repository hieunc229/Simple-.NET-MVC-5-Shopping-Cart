using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectricsOnlineWebApp.Startup))]
namespace ElectricsOnlineWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
