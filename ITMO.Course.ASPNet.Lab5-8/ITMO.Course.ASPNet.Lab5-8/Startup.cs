using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITMO.Course.ASPNet.Lab5_8.Startup))]
namespace ITMO.Course.ASPNet.Lab5_8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
