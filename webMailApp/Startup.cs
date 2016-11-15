using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webMailApp.Startup))]
namespace webMailApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
