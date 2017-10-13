using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadyTest.Startup))]
namespace ReadyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
