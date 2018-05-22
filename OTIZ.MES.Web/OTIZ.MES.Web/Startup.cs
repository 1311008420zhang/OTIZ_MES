using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTIZ.MES.Web.Startup))]
namespace OTIZ.MES.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
