using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Domain.Common;
using Com.Ktbl.FontHP.Map.Repository;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CommonController : ApiController
    {
        #region properties
        public StandardCodeRepository StandardCodeRepository { get; set; }
        public string Title { get; set; }

        #endregion

        // GET api/common
        public IEnumerable<StandardCodes> Get(string stdcode)
        {
            try
            {
                var value = Title;
                var result = StandardCodeRepository.GetStandardCodeWithCode(stdcode);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        


        // GET api/common/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/common
        public void Post([FromBody]string value)
        {
        }

        // PUT api/common/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/common/5
        public void Delete(int id)
        {
        }
    }
}
