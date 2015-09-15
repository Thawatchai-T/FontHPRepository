using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain
{
    public class FamilyDomain
    {
        public virtual string BrandCode { get; set; }
        public virtual string FamilyCode { get; set; }
        public virtual string FamilyNameENG { get; set; }
        public virtual string FamilyNameTH { get; set; }
        public virtual string SourceType { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as FamilyDomain;
            if (t == null) return false;
            if (BrandCode == t.BrandCode
             && FamilyCode == t.FamilyCode)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ BrandCode.GetHashCode();
            hash = (hash * 397) ^ FamilyCode.GetHashCode();

            return hash;
        }
        #endregion
    }
}
