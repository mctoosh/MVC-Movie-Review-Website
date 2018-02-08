using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunnersFilmMVC.Startup))]
namespace RunnersFilmMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
