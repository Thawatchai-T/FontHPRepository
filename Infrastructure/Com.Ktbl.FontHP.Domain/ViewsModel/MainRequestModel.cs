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
        public  string CId { get; set; }
        public  string Name { get; set; }
        public  string DealerName { get; set; }
        public  string StatusCode { get; set; }
        public  bool? IsLoan { get; set; }
        public  string RequestStatusName { get; set; }
        public  string IsGarantor { get; set; }
        public  string Ncb { get; set; }
        public  string DealerPriority { get; set; }
        public  bool? Active { get; set; }
    }
}
