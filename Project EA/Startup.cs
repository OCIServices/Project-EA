using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_EA.Startup))]
namespace Project_EA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
