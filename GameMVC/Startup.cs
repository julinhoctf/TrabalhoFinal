using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicMVC.Startup))]
namespace MusicMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
