using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS__Member_Registration.App_Start.Startup))]
namespace AngularJS__Member_Registration.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
