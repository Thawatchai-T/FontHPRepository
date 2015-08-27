using Com.Ktbl.FontHP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class MktLimit60Controller : ApiController
    {
        public List<Limit60Grid > GetGridLimit60Load()
        {
            List<Limit60Grid> list = new List<Limit60Grid>();
            var startdate = Convert.ToDateTime("2015-07-01");
            list.Add(new Limit60Grid { RequestDate= Convert.ToDateTime("17-04-2015"), RequestNo= "5501902", RequestStatus="บันทึกใบคำขออย่างย่อ",DayNum = 1295,BranchId = "00001"});
            list.Add(new Limit60Grid { RequestDate = Convert.ToDateTime("18-07-2015"), RequestNo = "5501903", RequestStatus = "บันทึกใบคำขออย่างย่อ", DayNum = 1295,BranchId = "00001"});
            list.Add(new Limit60Grid { RequestDate = Convert.ToDateTime("19-07-2015"), RequestNo = "5501904", RequestStatus = "บันทึกใบคำขออย่างย่อ", DayNum = 1296,BranchId = "00002" });
            list.Add(new Limit60Grid { RequestDate = Convert.ToDateTime("12-07-2015"), RequestNo = "5501905", RequestStatus = "บันทึกใบคำขออย่างย่อ", DayNum = 1297,BranchId = "00002" });
            return list;
        }

        public List<Limit60Grid> GetGridLimit60Load(string branchid)
        {

            List<Limit60Grid> list = new List<Limit60Grid>();
            list = GetGridLimit60Load().Where(l=>l.BranchId.Equals(branchid)).ToList<Limit60Grid>();
            //list.Where(person => person.Age > 30);
            return list;
            
        }
    }
}
