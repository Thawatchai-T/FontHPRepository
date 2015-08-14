using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Ktbl.FontHP.Domain.Common
{
    public class OccupationTypeDomain //: CommonDomain
    {
        public OccupationTypeDomain(){
            
            OccupationGroups = new OccupationGroupDomain();
            this.Positions = new List<PositionDomain>();

        }
        
        public virtual string Id { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual OccupationGroupDomain OccupationGroups { get; set; }
        
        public virtual List<PositionDomain> Positions { get; set; }

    }
}
