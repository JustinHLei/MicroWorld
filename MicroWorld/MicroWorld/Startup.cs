using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MicroWorld.Startup))]
namespace MicroWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
