using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PickersTunes.Startup))]
namespace PickersTunes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
