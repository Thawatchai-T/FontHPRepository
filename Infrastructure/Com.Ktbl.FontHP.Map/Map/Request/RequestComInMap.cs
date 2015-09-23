using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Request;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map.Request
{
    public class RequestComInMap : ClassMap<RequestComInDomain> {
        
        public RequestComInMap() {
            Table("Request_Com_Ins");
            LazyLoad();
            CompositeId().KeyProperty(x => x.RequestNo, "Request_No")
                         .KeyProperty(x => x.SeqNo, "Seq_No");
            Map(x => x.Saleman).Column("SaleMan").Length(15);
            Map(x => x.Salemanname).Column("SaleManName").Length(100);
            Map(x => x.Rate).Column("Rate").Precision(5).Scale(2);
            Map(x => x.Sumcomamt).Column("SumComAmt").Precision(13).Scale(2);
            Map(x => x.Comamt).Column("ComAmt").Precision(13).Scale(2);
            Map(x => x.Taxrate).Column("TaxRate").Precision(5).Scale(2);
            Map(x => x.Taxamt).Column("TaxAmt").Precision(13).Scale(2);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(10);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(10);
            Map(x => x.Active).Column("Active");
        }
    }
}
