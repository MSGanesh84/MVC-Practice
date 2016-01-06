using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day_2.Startup))]
namespace Day_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
