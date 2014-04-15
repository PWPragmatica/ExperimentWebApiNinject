using ExperimentWebApiNinject.Utilities.Interface;
using Ninject.Web.WebApi.Filter;
using System.Diagnostics;

namespace ExperimentWebApiNinject.ActionFilters
{
    public class MyGlobalActionFilter : AbstractActionFilter
    {
        private readonly IDateTimeProvider dateTimeProvider;

        public MyGlobalActionFilter(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            Debug.WriteLine(dateTimeProvider.CurrentUtcTime().ToString());
            base.OnActionExecuting(actionContext);
        }

        public override bool AllowMultiple
        {
            get { return true; }
        }
    }
}