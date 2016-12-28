using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesFiguresAPI.Startup))]
namespace SalesFiguresAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}