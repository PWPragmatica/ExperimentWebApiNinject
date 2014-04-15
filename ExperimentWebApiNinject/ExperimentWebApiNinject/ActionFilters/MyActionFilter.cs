using System.Web.Http.Filters;

namespace ExperimentWebApiNinject.ActionFilters
{
    public class MyActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
        }
    }
}