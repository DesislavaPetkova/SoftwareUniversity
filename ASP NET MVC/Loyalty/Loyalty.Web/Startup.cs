using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loyalty.Web.Startup))]
namespace Loyalty.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
