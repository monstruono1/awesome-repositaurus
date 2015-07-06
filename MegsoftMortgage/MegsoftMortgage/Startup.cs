using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegsoftMortgage.Startup))]
namespace MegsoftMortgage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
