using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.Common.Reqeust
{
    public class RequestStatusDomain
    {
        public virtual long Unikey { get; set; }
        public virtual string RequestNo { get; set; }
        public virtual int? SeqNo { get; set; }
        public virtual string ReqStatus { get; set; }
        //Maybe not use
        //public virtual DateTime? RequestDate { get; set; }
        public virtual DateTime? RequestDate { get; set; }
        public virtual string Remark { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual string UpdateBy { get; set; }
        public virtual string RemarkStatus { get; set; }
        public virtual string StatusName { get; set; }
    }
}
