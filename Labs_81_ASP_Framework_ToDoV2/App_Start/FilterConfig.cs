using System.Web;
using System.Web.Mvc;

namespace Labs_81_ASP_Framework_ToDoV2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
