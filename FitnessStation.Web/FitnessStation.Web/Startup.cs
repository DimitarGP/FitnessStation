using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessStation.Web.Startup))]
namespace FitnessStation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
