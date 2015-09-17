using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models

{
    //20150827 insert class p2p
    public class GridLead
    {
        public int Id { get; set; }
        public string ImportId { get; set; }
        public string CusName { get; set; }
        public string CusSurName { get; set; }
        public string LeadNo { get; set; }
        public string LeadNameGrid { get; set; }
        public string LeadSurNameGrid { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
    }
}