using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSCreatedRepository.Startup))]
namespace VSCreatedRepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
