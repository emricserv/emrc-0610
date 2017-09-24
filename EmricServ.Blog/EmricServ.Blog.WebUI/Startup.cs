using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmricServ.Blog.WebUI.Startup))]
namespace EmricServ.Blog.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
