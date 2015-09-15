using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain
{
    public class BrandDomain
    {
        public virtual string BrandCode { get; set; }
        public virtual string BrandNameENG { get; set; }
        public virtual string BrandNameTH { get; set; }
        public virtual string BrandType { get; set; }
        public virtual string SourceType { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
    }
}
