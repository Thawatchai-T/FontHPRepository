using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Ktbl.FontHP.Domain.Common;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class PositionMap : ClassMap<PositionDomain>
    {
        public PositionMap()
        {
            Table("View_Position");
            LazyLoad();
            Id(x => x.Id, "Position_ID").GeneratedBy.Assigned();
            References(x => x.OccupationType).Column("Career_ID");
            Map(x => x.Name).Column("Position_Name");
        }
            
    }
}
