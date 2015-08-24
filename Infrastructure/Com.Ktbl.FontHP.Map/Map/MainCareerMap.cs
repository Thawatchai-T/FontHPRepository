using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class MainCareerMap : ClassMap<MainCareerDomain>
    {

        public MainCareerMap()
        {
            Table("View_MainCareer_SelfMargin");

            Id(x => x.Id, "Career_Main_Code").GeneratedBy.Assigned();
            Map(x => x.Name).Column("Career_Main_Name").Length(500);
     
        }
    }
}
