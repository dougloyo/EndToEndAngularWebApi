using Microsoft.Owin;
using OAUTH.AuthenticationServer.Web;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace OAUTH.AuthenticationServer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}