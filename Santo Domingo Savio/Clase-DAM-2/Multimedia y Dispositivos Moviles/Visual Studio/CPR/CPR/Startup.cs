using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPR.Startup))]
namespace CPR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
