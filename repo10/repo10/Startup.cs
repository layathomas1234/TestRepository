using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(repo10.Startup))]
namespace repo10
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
