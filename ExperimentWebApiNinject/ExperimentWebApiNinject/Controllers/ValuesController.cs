﻿using ExperimentWebApiNinject.ActionFilters;
using ExperimentWebApiNinject.Utilities.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace ExperimentWebApiNinject.Controllers
{
    [MyControllerAction]
    public class ValuesController : ApiController
    {
        private readonly ILog log;

        public ValuesController(ILog log)
        {
            this.log = log;
        }

        // GET api/values
        [MyAction]
        public IEnumerable<string> Get()
        {
            log.Write("ValuesController: Get()");
            return new string[] { "value1", "value2" };
        }
    }
}