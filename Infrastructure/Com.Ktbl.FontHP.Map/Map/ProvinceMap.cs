using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class ProvinceMap : ClassMap<ProvinceDomain>
    {

        public ProvinceMap()
        {
            Table("province");
            LazyLoad();
            Id(x => x.ProvinceId).GeneratedBy.Assigned().Column("pvcode");
            Map(x => x.Region).Column("Region").Length(1);
            Map(x => x.DistrictId).Column("amcode").Length(2);
            Map(x => x.SubDistrictID).Column("ttcode").Length(2);
            Map(x => x.MouCode).Column("moucode").Length(2);
            Map(x => x.ProvinceName).Column("name").Length(50);
            Map(x => x.BranchCode).Column("Branch_code").Length(50);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(10);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(10);
            Map(x => x.Active).Column("Active");
        }
    }
}
