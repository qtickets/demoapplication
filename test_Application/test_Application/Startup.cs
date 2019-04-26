using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_Application.Startup))]
namespace test_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
