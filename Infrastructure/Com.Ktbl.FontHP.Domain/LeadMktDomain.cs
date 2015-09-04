using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain
{
    public class LeadMktDomain
    {
        public virtual string MktCode { get; set; }
        public virtual string MktName { get; set; }
        public virtual string MktHead { get; set; }
        public virtual bool? FlagAssign { get; set; }
        public virtual string EmpGroup { get; set; }
        public virtual string EmpId { get; set; }
        public virtual string TelContact { get; set; }
        public virtual string TelPerson { get; set; }
        public virtual bool? IsLeadMail { get; set; }
        public virtual string LeadMailName { get; set; }
        public virtual string TelNumber { get; set; }
        public virtual DateTime? StartWork { get; set; }
        public virtual DateTime? ExpWork { get; set; }
        public virtual bool? Tablet { get; set; }
        public virtual DateTime? RTNDate { get; set; }
        public virtual string SerialNo { get; set; }
        public virtual string MktStatus { get; set; }
        public virtual string MktNickName { get; set; }
        public virtual int? LevelGroup { get; set; }
        public virtual string SubGroup { get; set; }
        public virtual string Branch { get; set; }
        public virtual string BranchK { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? IsActive { get; set; }
        public virtual string Userad { get; set; }
    }
}