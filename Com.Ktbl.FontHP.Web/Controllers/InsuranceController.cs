using Com.Ktbl.FontHP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class InsuranceController : ApiController
    {
        // GET api/insurance
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/insurance/5
        public string Get(int id)
        {
            return "value";
        }

        public InsuranceViewModel GetInsurenByRequstId(int requestid)
        {
            //var data = new DataModel<InsuranceViewModel>();
            //data.success = true;
            //data.data = new InsuranceViewModel();
            return new InsuranceViewModel();
        }

        // POST api/insurance
        public void Post([FromBody]string value)
        {
        }

        // PUT api/insurance/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/insurance/5
        public void Delete(int id)
        {
        }
    }

    
}
