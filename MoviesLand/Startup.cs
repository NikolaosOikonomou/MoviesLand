using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesLand.Startup))]
namespace MoviesLand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
