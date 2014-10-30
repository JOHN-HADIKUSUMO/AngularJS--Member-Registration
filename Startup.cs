using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS__Member_Registration.Startup))]
namespace AngularJS__Member_Registration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
