using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Default.Startup))]
namespace Default
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
