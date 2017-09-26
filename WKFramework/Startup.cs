using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WKFramework.Startup))]
namespace WKFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
