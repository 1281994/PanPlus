using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica2cmi.Startup))]
namespace Practica2cmi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
