using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XamarinSales.Backend.Startup))]
namespace XamarinSales.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
