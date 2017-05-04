using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendshipShoppingCart.Startup))]
namespace FriendshipShoppingCart
{
    public partial class Startup
    {//startup
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
