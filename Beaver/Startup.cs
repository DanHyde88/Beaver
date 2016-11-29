using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beaver.Startup))]
namespace Beaver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
