using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnMobileApplication.Startup))]
namespace OnMobileApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
