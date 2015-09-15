using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    class ThirdPartyMarketingMap : ClassMap<ThirdPartyMarketingDomain>
    {

        public ThirdPartyMarketingMap()
        {
            Table("ThirdParty_MKT");
            LazyLoad();
            CompositeId().KeyProperty(x => x.DealerCode, "Dealer_Code")
                       .KeyProperty(x => x.MarketingCode, "Mkt_Code");
            Map(x => x.TitleName).Column("TitleName");
            Map(x => x.MarketingName).Column("Mkt_Name");
            Map(x => x.MarketingSurName).Column("Mkt_Sname");
            Map(x => x.Id).Column("ID");
            Map(x => x.BankCode).Column("Bank_Code");
            Map(x => x.BranchId).Column("Branch_ID");
            Map(x => x.BranchBankOther).Column("Branch_BankOther");
            Map(x => x.AccountNo).Column("Account_No");
            Map(x => x.Address1).Column("Addr1");
            Map(x => x.Address2).Column("Addr2"); 
            Map(x => x.Address3).Column("Addr3");
            Map(x => x.Mtype).Column("MType");
            Map(x => x.TypeCar01).Column("Type_car01");
            Map(x => x.TypeCar03).Column("Type_car03");
            Map(x => x.TypeVan).Column("Type_VAN");
            Map(x => x.ComType).Column("ComType");
            Map(x => x.Seq).Column("seq");
            Map(x => x.DealerSubCode).Column("Dealer_subCode");
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User");
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User");
            Map(x => x.IsActive).Column("Active");
           
        }
    }
}
