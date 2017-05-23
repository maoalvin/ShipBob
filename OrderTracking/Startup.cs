using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderTracking.Startup))]
namespace OrderTracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
