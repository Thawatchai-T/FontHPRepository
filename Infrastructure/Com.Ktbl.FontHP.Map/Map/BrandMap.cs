using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class BrandMap : ClassMap<BrandDomain>
    {

        public BrandMap()
        {
            Table("Brand");
            LazyLoad();
            Id(x => x.BrandCode).GeneratedBy.Assigned().Column("Brand_Code");
            Map(x => x.BrandNameENG).Column("Brand_Name_EN").Length(50);
            Map(x => x.BrandNameTH).Column("Brand_Name_TH").Length(50);
            Map(x => x.BrandType).Column("Brand_Type").Length(1);
            Map(x => x.SourceType).Column("Source_Type").Length(1);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(20);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(20);
            Map(x => x.Active).Column("Active");
        }
    }
}
