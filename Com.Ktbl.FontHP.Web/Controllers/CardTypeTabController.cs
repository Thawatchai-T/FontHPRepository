using Com.Ktbl.FontHP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CardTypeTabController : ApiController
    {
        public PageModelView<CardTypeViewModel> GetCardTypeLoad(int start, int limit, int page)
        {
            List<CardTypeViewModel> list = new List<CardTypeViewModel>();
            var pagemodel = new PageModelView<CardTypeViewModel>();
            for (int i = 0; i < 10; i++)
            {
                var obj = new CardTypeViewModel
                {
                    CardNo = string.Format("333500001125{0}", i.ToString()),
                    ExpireDate = DateTime.Now,
                    id = i,
                    IssueDate = DateTime.Now,
                    TypeCard = string.Format("0{0}", i)
                };
                list.Add(obj);
            }
            pagemodel.items = list;
            pagemodel.total = 10;
            return pagemodel;

        }

        public Boolean Insert(CardTypeViewModel obj)
        {

            if (obj.id != null)
            {
                //Update
            }
            else
            {
                //Insert
            }

            return true;
        }

        public CardTypeViewModel GetCardTypeById(int id)
        {
            var result = new CardTypeViewModel
            {
                id = 15,
                CardNo = "1111111235555",
                ExpireDate = Convert.ToDateTime("17-04-2019"),
                IssueDate =Convert.ToDateTime("17-04-2011"),
                TypeCard = "01",
                TypeCustomer = "02"
    
            };
            return result;
        }
        public void Delete(int id)
        {
            //TODO:  not implement
        }


    }
}
