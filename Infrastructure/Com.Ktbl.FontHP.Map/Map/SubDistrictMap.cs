using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class SubDistrictMap: ClassMap<SubDistrictDomain> {

        public SubDistrictMap()
        {
            Table("tumbon");
            LazyLoad();
            CompositeId().KeyProperty(x => x.ProvinceId, "pvcode")
                         .KeyProperty(x => x.DistrictId, "amcode")
                         .KeyProperty(x => x.SubDistrictId, "ttcode");
            Map(x => x.Moucode).Column("moucode").Length(2);
            Map(x => x.SubDistrictName).Column("name").Length(50);
            Map(x => x.Zipcode).Column("ZIPCODE").Length(6);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(10);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(10);
            Map(x => x.Active).Column("Active");
        }
    }
}
