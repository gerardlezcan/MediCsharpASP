using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediCsharpASP.Startup))]
namespace MediCsharpASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
