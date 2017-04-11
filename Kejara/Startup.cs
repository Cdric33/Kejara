using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kejara.Startup))]
namespace Kejara
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}