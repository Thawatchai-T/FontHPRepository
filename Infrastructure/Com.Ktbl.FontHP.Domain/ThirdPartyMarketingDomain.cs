using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain
{
    public class ThirdPartyMarketingDomain
    {

        //add Domain p2p 20150914
        public virtual string DealerCode { get; set; }
     
        public virtual string MarketingCode { get; set; }

        public virtual string TitleName { get; set; }

        public virtual string MarketingName { get; set; }

        public virtual string MarketingSurName { get; set; }

        public virtual string Id { get; set; }

        public virtual string BankCode { get; set; }

        public virtual string BranchId { get; set; }

        public virtual string BranchBankOther { get; set; }

        public virtual string AccountNo { get; set; }

        public virtual string Address1 { get; set; }

        public virtual string Address2 { get; set; }

        public virtual string Address3 { get; set; }

        public virtual string Mtype { get; set; }

        public virtual decimal TypeCar01 { get; set; }

        public virtual decimal TypeCar03 { get; set; }

        public virtual decimal TypeVan { get; set; }

        public virtual string ComType { get; set; }

        public virtual int Seq { get; set; }

        public virtual string DealerSubCode { get; set; }

        public virtual DateTime?  CreateDate { get; set; }

        public virtual string CreateUser { get; set; }

        public virtual DateTime? ModifyDate { get; set; }

        public virtual string ModifyUser { get; set; }

        public virtual bool? IsActive { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as ThirdPartyMarketingDomain;
            if (t == null) return false;
            if (DealerCode == t.DealerCode
             && MarketingCode == t.MarketingCode)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ DealerCode.GetHashCode();
            hash = (hash * 397) ^ MarketingCode.GetHashCode();

            return hash;
        }
        #endregion

        
    }
}