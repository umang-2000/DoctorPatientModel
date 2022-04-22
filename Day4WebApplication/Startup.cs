using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day4WebApplication.Startup))]
namespace Day4WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
