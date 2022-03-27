using System.Web;
using System.Web.Mvc;

namespace _1911065227_BigSchool_NguyenHuyHoang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
