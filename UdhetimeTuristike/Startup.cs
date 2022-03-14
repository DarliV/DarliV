using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdhetimeTuristike.Startup))]
namespace UdhetimeTuristike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
