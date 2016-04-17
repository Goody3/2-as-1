using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2as1.Startup))]
namespace _2as1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
