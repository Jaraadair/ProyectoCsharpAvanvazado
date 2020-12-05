using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPBiblioteca.Startup))]
namespace TPBiblioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
