using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CibraryP_K.Startup))]
namespace CibraryP_K
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
