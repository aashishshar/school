using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_APP_Edu.Startup))]
namespace Web_APP_Edu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
