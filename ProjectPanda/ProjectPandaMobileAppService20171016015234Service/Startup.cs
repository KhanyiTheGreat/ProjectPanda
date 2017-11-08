using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProjectPandaMobileAppService20171016015234Service.Startup))]

namespace ProjectPandaMobileAppService20171016015234Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}