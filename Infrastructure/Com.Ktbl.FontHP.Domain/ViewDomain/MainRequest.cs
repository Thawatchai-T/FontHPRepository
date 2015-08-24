using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.ViewDomain
{
    public class MainRequest
    {
        public virtual string RequestNo { get; set; }
        public virtual DateTime? RequestDate { get; set; }
        public virtual string BranchNo { get; set; }
        public virtual string CId { get; set; }
        public virtual string TitleName { get; set; }
        public virtual string FNameThai { get; set; }
        public virtual string LNameThai { get; set; }
        public virtual string DealerTitle { get; set; }
        public virtual string DealerFName { get; set; }
        public virtual string DealerLName { get; set; }
        public virtual string StatusCode { get; set; }
        public virtual bool? IsLoan { get; set; }
        public virtual string RequestStatusName { get; set; }
        public virtual string IsGarantor { get; set; }
        public virtual string Ncb { get; set; }
        public virtual string DealerPriority { get; set; }
        public virtual bool? Active { get; set; }
    }
}
