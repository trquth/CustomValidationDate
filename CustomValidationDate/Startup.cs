using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomValidationDate.Startup))]
namespace CustomValidationDate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
