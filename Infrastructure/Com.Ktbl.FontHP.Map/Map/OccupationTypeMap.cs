using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Ktbl.FontHP.Domain.Common;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class OccupationTypeMap : ClassMap<OccupationTypeDomain>
    {
        public OccupationTypeMap()
        {
            Table("View_OccupationType");
            LazyLoad();
            Id(x => x.Id, "Career_ID").GeneratedBy.Assigned();
            References(x => x.OccupationGroups).Column("Group_ID");
           // HasMany(x => x.Positions).KeyColumn("Career_ID");

            Map(x => x.Name).Column("Career_Name");

        }
            
    }
}
