using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CATCUSTINFO.Startup))]
namespace CATCUSTINFO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
