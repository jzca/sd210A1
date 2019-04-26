using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sd210A1FilterHelper.Startup))]
namespace sd210A1FilterHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
