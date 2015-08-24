using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.ViewDomain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class MainRequestMap: ClassMap<MainRequest>
    {
        public MainRequestMap()
        {
            Table("View_MainRequest");
            LazyLoad();
            //Map(x => x.RequestNo).Column("Request_No").Not.Nullable().Length(10);
            Id(x => x.RequestNo, "Request_No").GeneratedBy.Assigned();
            Map(x => x.RequestDate).Column("RequestDateTime");
            Map(x => x.BranchNo).Column("Branch").Length(5);
            Map(x => x.CId).Column("IdCode").Length(30);
            Map(x => x.TitleName).Column("TitleName").Length(100);
            Map(x => x.FNameThai).Column("F_Name_Thai").Length(50);
            Map(x => x.LNameThai).Column("L_Name_Thai").Length(50);
            Map(x => x.DealerTitle).Column("Dealer_title").Length(100);
            Map(x => x.DealerFName).Column("Dealer_F_Name").Length(80);
            Map(x => x.DealerLName).Column("Dealer_L_Name").Length(80);
            Map(x => x.StatusCode).Column("RequestStatusCode").Length(5);
            Map(x => x.IsLoan).Column("Flag_Loan");
            Map(x => x.RequestStatusName).Column("RequestStatusName").Length(100);
            Map(x => x.IsGarantor).Column("nouseflgGarantor").Not.Nullable().Length(1);
            Map(x => x.Ncb).Column("noNCB").Not.Nullable().Length(1);
            Map(x => x.DealerPriority).Column("noOrderbyDealerPriority").Not.Nullable().Length(1);
            Map(x => x.Active).Column("Active");
        }
    }
}
