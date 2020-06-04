using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xuanthoailab456.Startup))]
namespace xuanthoailab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
