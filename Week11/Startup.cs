using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week10.Startup))]
namespace Week10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
