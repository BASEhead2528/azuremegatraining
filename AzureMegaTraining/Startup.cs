using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMegaTraining.Startup))]
namespace AzureMegaTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
