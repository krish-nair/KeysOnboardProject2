using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeysOnboardProject2.Startup))]
namespace KeysOnboardProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
