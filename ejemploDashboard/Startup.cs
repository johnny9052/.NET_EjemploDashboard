using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejemploDashboard.Startup))]
namespace ejemploDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
