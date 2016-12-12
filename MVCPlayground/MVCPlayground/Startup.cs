using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPlayground.Startup))]
namespace MVCPlayground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}