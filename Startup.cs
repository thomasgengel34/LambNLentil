using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LambNLentil.Startup))]
namespace LambNLentil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
