﻿using ExperimentWebApiNinject.Utilities.Interface;
using Ninject.Web.WebApi.Filter;
using System.Diagnostics;

namespace ExperimentWebApiNinject.ActionFilters
{
    public class MyGlobalActionFilter : AbstractActionFilter
    {
        private readonly ILog log;

        public MyGlobalActionFilter(ILog log)
        {
            this.log = log;
        }

        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            log.Write("MyGlobalActionFilter: OnActionExecuting");
            base.OnActionExecuting(actionContext);
        }

        public override bool AllowMultiple
        {
            get { return true; }
        }
    }
}