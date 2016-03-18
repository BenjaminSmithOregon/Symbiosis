using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sprint1Test.Startup))]
namespace Sprint1Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
