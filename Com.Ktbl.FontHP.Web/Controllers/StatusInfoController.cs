using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Web.Models;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class StatusInfoController : ApiController
    {
        public PageModel<StatusViewModel> GetStatusInfoLoad()
        {
            List<StatusViewModel> list = new List<StatusViewModel>();
            var pagemodel = new PageModel<StatusViewModel>();

            list.Add(new StatusViewModel { id = 1, Status = "100", Decription = "ยกเลิก", InsertDate = Convert.ToDateTime("10-04-2013"), CreateUser = "สายใจ สมดี" });
            list.Add(new StatusViewModel { id = 2, Status = "010", Decription = "นำส่ง", InsertDate = Convert.ToDateTime("17-07-2015"), CreateUser = "สายสมร สมใจ" });
            list.Add(new StatusViewModel { id = 3, Status = "500", Decription = "ยกเลิก", InsertDate = Convert.ToDateTime("11-06-2014"), CreateUser = "สายหยุด สมควร" });
            list.Add(new StatusViewModel { id = 4, Status = "200", Decription = "นำส่ง", InsertDate = Convert.ToDateTime("08-04-2015"), CreateUser = "สายป่าน สมแล้ว" });
            pagemodel.items = list;
            pagemodel.total = 10;
            return pagemodel;
        }
    }
}
