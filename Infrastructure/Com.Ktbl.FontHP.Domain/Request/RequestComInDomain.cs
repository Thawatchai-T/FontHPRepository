using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.Request
{
    public class RequestComInDomain
    {
        public virtual string RequestNo { get; set; }
        public virtual int SeqNo { get; set; }
        public virtual string Saleman { get; set; }
        public virtual string Salemanname { get; set; }
        public virtual double? Rate { get; set; }
        public virtual double? Sumcomamt { get; set; }
        public virtual double? Comamt { get; set; }
        public virtual double? Taxrate { get; set; }
        public virtual double? Taxamt { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as RequestComInDomain;
            if (t == null) return false;
            if (RequestNo == t.RequestNo
             && SeqNo == t.SeqNo)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ RequestNo.GetHashCode();
            hash = (hash * 397) ^ SeqNo.GetHashCode();

            return hash;
        }
        #endregion
    }
}