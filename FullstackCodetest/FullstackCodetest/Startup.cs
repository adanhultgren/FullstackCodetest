using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullstackCodetest.Startup))]
namespace FullstackCodetest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
