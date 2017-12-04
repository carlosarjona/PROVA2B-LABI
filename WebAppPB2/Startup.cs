using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPB2.Startup))]
namespace WebAppPB2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
