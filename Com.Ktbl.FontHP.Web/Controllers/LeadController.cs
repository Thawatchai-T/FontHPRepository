using Com.Ktbl.FontHP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class LeadController : ApiController
    {
        // GET api/leadviewmodel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/leadviewmodel/5
        public string Get(int id)
        {
            return "value";
        }
        public LeadModel GetLeadById(int id)
        {
            var result = new LeadModel
            {
                LeadId = "00001",
                LeadNo = "LD001"
               
            };
            return result;
        }

        // POST api/leadviewmodel
        public void Post([FromBody]string value)
        {
        }

        // PUT api/leadviewmodel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/leadviewmodel/5
        public void Delete(int id)
        {
        }
    }
}
