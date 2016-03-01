using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(knockoutApp2.Startup))]
namespace knockoutApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
