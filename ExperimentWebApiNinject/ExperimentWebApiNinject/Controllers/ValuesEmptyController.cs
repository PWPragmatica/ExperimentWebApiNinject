using ExperimentWebApiNinject.Utilities.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace ExperimentWebApiNinject.Controllers
{
    public class ValuesEmptyController : ApiController
    {
        private readonly ILog log;

        public ValuesEmptyController(ILog log)
        {
            this.log = log;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            log.Write("ValuesController: Get()");
            return new string[] { "ValuesEmpty1", "ValuesEmpty2" };
        }
    }
}