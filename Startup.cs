using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaviMVCApp.Startup))]
namespace RaviMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
