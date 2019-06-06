using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labs_84_ASP_MVC_With_Authentication.Startup))]
namespace Labs_84_ASP_MVC_With_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
