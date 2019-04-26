using System.Web;
using System.Web.Mvc;

namespace sd210A1FilterHelper
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
