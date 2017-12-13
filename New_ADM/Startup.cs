using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_ADM.Startup))]
namespace New_ADM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
