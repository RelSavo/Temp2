using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Temp2Website.Startup))]
namespace Temp2Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
