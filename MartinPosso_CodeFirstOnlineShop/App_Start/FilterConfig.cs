using System.Web;
using System.Web.Mvc;

namespace MartinPosso_CodeFirstOnlineShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
