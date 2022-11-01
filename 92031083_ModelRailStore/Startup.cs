using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_92031083_ModelRailStore.Startup))]
namespace _92031083_ModelRailStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
