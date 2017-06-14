using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductOrder.Startup))]
namespace ProductOrder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
