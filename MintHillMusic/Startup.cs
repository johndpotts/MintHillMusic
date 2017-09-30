using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MintHillMusic.Startup))]
namespace MintHillMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
