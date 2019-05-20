using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maja_testiranje.Startup))]
namespace Maja_testiranje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
