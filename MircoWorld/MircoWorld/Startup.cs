using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MircoWorld.Startup))]
namespace MircoWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
