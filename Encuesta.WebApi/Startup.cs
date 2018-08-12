using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Encuesta.WebApi.Startup))]
namespace Encuesta.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
