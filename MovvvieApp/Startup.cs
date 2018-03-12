using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovvvieApp.Startup))]
namespace MovvvieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
