using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common.Reqeust;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class RequestStatusMap : ClassMap<RequestStatusDomain>
    {

        public RequestStatusMap()
        {
            Table("Request_Status");
            LazyLoad();
            Id(x => x.Unikey).GeneratedBy.Identity().Column("UNIKEY");
            Map(x => x.RequestNo).Column("Request_No").Length(10);
            Map(x => x.SeqNo).Column("Seq_No").Precision(10);
            Map(x => x.ReqStatus).Column("Req_Status").Length(5);
            //Map(x => x.RequestDate).Column("ReqDate");
            Map(x => x.RequestDate).Column("Req_Date");
            Map(x => x.Remark).Column("Remark").Length(100);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(20);
            Map(x => x.UpdateDate).Column("Modify_Date");
            Map(x => x.UpdateBy).Column("Modify_User").Length(20);
            Map(x => x.RemarkStatus).Column("Remark_sts").Length(100);
            Map(x => x.StatusName).Column("StatusName").Length(200);
        }
    }
}
