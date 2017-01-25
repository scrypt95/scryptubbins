using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(snproject.Startup))]
namespace snproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
