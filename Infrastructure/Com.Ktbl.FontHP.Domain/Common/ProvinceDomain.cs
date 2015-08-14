using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.Common
{
    public class ProvinceDomain
    {
        public virtual string ProvinceId { get; set; }
        public virtual string Region { get; set; }
        public virtual string DistrictId { get; set; }
        public virtual string SubDistrictID { get; set; }
        public virtual string MouCode { get; set; }
        public virtual string ProvinceName { get; set; }
        public virtual string BranchCode { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
    }
}
