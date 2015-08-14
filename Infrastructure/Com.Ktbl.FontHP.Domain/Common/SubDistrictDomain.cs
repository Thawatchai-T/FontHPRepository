using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.Common
{
    public class SubDistrictDomain
    {
        public virtual string ProvinceId { get; set; }
        public virtual string DistrictId { get; set; }
        public virtual string SubDistrictId { get; set; }
        public virtual string Moucode { get; set; }
        public virtual string SubDistrictName { get; set; }
        public virtual string Zipcode { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as SubDistrictDomain;
            if (t == null) return false;
            if (ProvinceId == t.ProvinceId
             && DistrictId == t.DistrictId
             && SubDistrictId == t.SubDistrictId)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ ProvinceId.GetHashCode();
            hash = (hash * 397) ^ DistrictId.GetHashCode();
            hash = (hash * 397) ^ SubDistrictId.GetHashCode();

            return hash;
        }
        #endregion
    }
}
