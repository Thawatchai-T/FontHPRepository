using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain
{
    public class EntrelDomain
    {
        public virtual string ComId { get; set; }
        public virtual string EntCode { get; set; }
        public virtual string NameTH { get; set; }
        public virtual string NameENG { get; set; }
        public virtual string TitleTH { get; set; }
        public virtual string TitleENG { get; set; }
        public virtual string TaxId { get; set; }
        public virtual string Contact { get; set; }
        public virtual string TypeEnt { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string EMail { get; set; }
        public virtual string OthComm { get; set; }
        public virtual string Activity { get; set; }
        public virtual DateTime? StartDd { get; set; }
        public virtual string IdDesc { get; set; }
        public virtual DateTime? Issued { get; set; }
        public virtual DateTime? Expire { get; set; }
        public virtual string Race { get; set; }
        public virtual string Nation { get; set; }
        public virtual string Sex { get; set; }
        public virtual double? CrLine { get; set; }
        public virtual string Grpcode { get; set; }
        public virtual string Cat1 { get; set; }
        public virtual string Cat2 { get; set; }
        public virtual string Cat3 { get; set; }
        public virtual string Cat4 { get; set; }
        public virtual string Cat5 { get; set; }
        public virtual string Cat6 { get; set; }
        public virtual double? Amount1 { get; set; }
        public virtual double? Amount2 { get; set; }
        public virtual double? Amount3 { get; set; }
        public virtual double? Amount4 { get; set; }
        public virtual double? Amount5 { get; set; }
        public virtual double? Amount6 { get; set; }
        public virtual string IssuBy { get; set; }
        public virtual string Marital { get; set; }
        public virtual string Spouse { get; set; }
        public virtual double? Income { get; set; }
        public virtual string OthInc { get; set; }
        public virtual string Mobile2 { get; set; }
        public virtual string TranferBy { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as EntrelDomain;
            if (t == null) return false;
            if (ComId == t.ComId
             && EntCode == t.EntCode)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ ComId.GetHashCode();
            hash = (hash * 397) ^ EntCode.GetHashCode();

            return hash;
        }
        #endregion

        
    }
}
