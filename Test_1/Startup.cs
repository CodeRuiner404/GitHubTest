using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_1.Startup))]
namespace Test_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
