using System.Web;
using System.Web.Mvc;

namespace Town_MVC_LINQTOSql_Web_app
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
