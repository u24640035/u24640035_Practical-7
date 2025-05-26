using System.Web;
using System.Web.Mvc;

namespace u24640035_Practical_7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
