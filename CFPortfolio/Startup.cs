using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CFPortfolio.Startup))]
namespace CFPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
