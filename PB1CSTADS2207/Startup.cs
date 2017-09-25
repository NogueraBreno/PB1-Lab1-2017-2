using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PB1CSTADS2207.Startup))]
namespace PB1CSTADS2207
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
