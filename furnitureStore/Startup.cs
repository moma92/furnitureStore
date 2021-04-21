using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(furnitureStore.Startup))]
namespace furnitureStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
