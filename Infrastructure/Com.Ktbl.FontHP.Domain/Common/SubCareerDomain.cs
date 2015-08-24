using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Ktbl.FontHP.Domain.Common
{
    public class SubCareerDomain //: CommonDomain
    {
        public SubCareerDomain()
        {
           
        }
        public virtual string Id { get; set; }
        public virtual string MainCareerId { get; set; }
        public virtual string Name { get; set; }
        
    }
}
