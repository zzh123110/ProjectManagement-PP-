using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaffWebApplication.Startup))]
namespace StaffWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
