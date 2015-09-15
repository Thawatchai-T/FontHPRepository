using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class InsLoanProtectionModel
    {

        public int RequestNo { get; set; }
        public string LoanProtectPoicyNo { get; set; }
        public DateTime LoanProtectStart { get; set; }
        public DateTime LoanProtectEnd { get; set; }
        public string LoanProtectNo { get; set; }
        public DateTime LoanProtectRequestDate { get; set; }
        public string RejectReason { get; set; }
    }

}