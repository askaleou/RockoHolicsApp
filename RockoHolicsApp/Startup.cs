using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RockoHolicsApp.Startup))]
namespace RockoHolicsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
