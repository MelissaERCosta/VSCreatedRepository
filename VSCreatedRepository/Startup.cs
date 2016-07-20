using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSCreatedRepository.Startup))]
namespace VSCreatedRepository
{
    /* This is a comment */
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
