using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendshipShoppingCart.Startup))]
namespace FriendshipShoppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
