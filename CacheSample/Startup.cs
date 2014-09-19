using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CacheSample.Startup))]
namespace CacheSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
