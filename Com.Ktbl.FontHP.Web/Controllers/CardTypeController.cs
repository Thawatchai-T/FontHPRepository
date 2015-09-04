using Com.Ktbl.FontHP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CardTypeController : ApiController
    {
        // GET api/cardtype
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/cardtype/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/cardtype
        public void Post(CardTypeViewModel modle)
        {

        }

        // PUT api/cardtype/5
        public void Put(int id, [FromBody]CardTypeViewModel modle)
        {
        }

        // DELETE api/cardtype/5
        public void Delete(int id)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public PageModel<CardTypeViewModel> GetAllCardType(int start, int limit, int page)
        {
            try
            {
                List<CardTypeViewModel> list = new List<CardTypeViewModel>();
                var pagemodel = new PageModel<CardTypeViewModel>();
                for (int i = 0; i < 10; i++)
                {
                    var obj = new CardTypeViewModel
                    {
                        CardNo = string.Format("333500001125{0}",i.ToString()),
                        ExpireDate = DateTime.Now,
                        id = i,
                        IssueDate = DateTime.Now,
                        TypeCard = string.Format("0{0}",i)
                    };
                    list.Add(obj);
                }
                pagemodel.items = list;
                pagemodel.total = 10;
                return pagemodel;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
    }
}
