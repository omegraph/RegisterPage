using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductRecall.WebMVC.Startup))]
namespace ProductRecall.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
