using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class SubCareerMap : ClassMap<SubCareerDomain>
    {

        public SubCareerMap()
        {
            Table("View_SubCareer_SelfMargin");

            Id(x => x.Id, "Career_Sub_Code").GeneratedBy.Assigned();
            Map(x => x.MainCareerId).Column("Career_Main_Code").Length(500);
            Map(x => x.Name).Column("Career_Sub_Name").Length(500);
     
        }
    }
}
