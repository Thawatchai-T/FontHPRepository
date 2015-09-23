using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.Request
{
    public class RequestPaydealerDomain
    {
        public virtual string RequestNo { get; set; }
        public virtual string MktCode { get; set; }
        public virtual string MktName { get; set; }
        public virtual string DealerCode { get; set; }
        public virtual double? ComAmt { get; set; }
        public virtual double? ComLoan { get; set; }
        public virtual double? ComTotal { get; set; }
        public virtual double? ComTrs { get; set; }
        public virtual double? ComWhtRate { get; set; }
        public virtual double? ComWhtAmt { get; set; }
        public virtual double? ComNet { get; set; }
        public virtual double? ComVat { get; set; }
        public virtual double? ComIncVat { get; set; }
        public virtual double? ComIncVatLoan { get; set; }
        public virtual string Comtype { get; set; }
        public virtual bool? FlagSendacc { get; set; }
        public virtual DateTime? SendaccDate { get; set; }
        public virtual DateTime? ComDd { get; set; }
        public virtual string SendaccBy { get; set; }
        public virtual bool? FlagPay { get; set; }
        public virtual bool? FlagPrinttax { get; set; }
        public virtual DateTime? PaidDate { get; set; }
        public virtual string PrinttaxBy { get; set; }
        public virtual string Bank { get; set; }
        public virtual string Branch { get; set; }
        public virtual string Accountno { get; set; }
        public virtual string Typeent { get; set; }
        public virtual string CarType01 { get; set; }
        public virtual string CarType03 { get; set; }
        public virtual string CarTypevan { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
    }
}