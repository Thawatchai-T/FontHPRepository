using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class CheckDocumentViewModel
    {
        public int id { get; set; }
        public string RequestNo { get; set; }
        public DateTime RequestDate { get; set; }
        public string IdApprove { get; set; }
        public string CitizenId { get; set; }
        public string CusName { get; set; }
        public string TypeLoan { get; set; }
        public string BranchName { get; set; }
        public string National { get; set; }


    }
}