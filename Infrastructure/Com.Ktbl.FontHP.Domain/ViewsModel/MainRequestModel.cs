using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.ViewsModel
{
    public class MainRequestModel
    {
        public  string RequestNo { get; set; }
        public  DateTime? RequestDate { get; set; }
        public  string BranchNo { get; set; }
        public  string CitizenId { get; set; }
        public  string CusName { get; set; }
        public  string DealerName { get; set; }

        public string Document {get;set;}
        public string Return {get;set;}
        public  string StatusCode { get; set; }
        public  bool? Loan { get; set; }
        public  string RequestStatus { get; set; }
        public  string IsGarantor { get; set; }

        public string GurantorName {get;set;}
        public string NCBStatus { get; set; }
        public  string Ncb { get; set; }
        public  string DealerPriority { get; set; }
        public  bool? Active { get; set; }

        public string Doc1 {get; set; }
        public string Doc2 {get; set; }
        public string Doc3 {get; set; }

    }
}