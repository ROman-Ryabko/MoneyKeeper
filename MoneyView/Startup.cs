using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyView.Startup))]
namespace MoneyView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
