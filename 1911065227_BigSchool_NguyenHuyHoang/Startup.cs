using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065227_BigSchool_NguyenHuyHoang.Startup))]
namespace _1911065227_BigSchool_NguyenHuyHoang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
