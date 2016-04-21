using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CCA.Startup))]
namespace CCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
