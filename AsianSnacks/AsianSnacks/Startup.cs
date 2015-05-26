using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsianSnacks.Startup))]
namespace AsianSnacks
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
