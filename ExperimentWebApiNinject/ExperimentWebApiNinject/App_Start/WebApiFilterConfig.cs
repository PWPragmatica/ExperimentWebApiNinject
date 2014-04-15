using ExperimentWebApiNinject.ActionFilters;

namespace ExperimentWebApiNinject
{
    public class WebApiFilterConfig
    {
        public static void RegisterGlobalFilters(System.Web.Http.Filters.HttpFilterCollection filters)
        {
            filters.Add(new MyGlobalActionFilter());
        }
    }
}