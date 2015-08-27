using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class Limit60Grid
    {
        //20150827 insert class  p2p
        public DateTime  RequestDate { get; set; }
        public string RequestNo { get; set; }
        public string RequestStatus { get; set; }
        public int DayNum { get; set; }

        public string BranchId { get; set; }
    }
}