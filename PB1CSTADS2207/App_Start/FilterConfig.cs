using System.Web;
using System.Web.Mvc;

namespace PB1CSTADS2207
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
