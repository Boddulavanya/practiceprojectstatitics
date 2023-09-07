using System.Web;
using System.Web.Mvc;

namespace Display_Statistics_of_Marks_Obtained_by_Students
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
