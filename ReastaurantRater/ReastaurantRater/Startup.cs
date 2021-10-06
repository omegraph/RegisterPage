using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReastaurantRater.Startup))]
namespace ReastaurantRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
