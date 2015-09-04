using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.ViewDomain
{
   public  class AddressDomain
    {
       public virtual int id { get; set; }

        public virtual string AddressType { get; set; }
        public virtual string RegistNo { get; set; }
        public virtual string AddressNo { get; set; }
        public virtual string Moo { get; set; }
        public virtual string MooBaan { get; set; }
        public virtual string Soi { get; set; }
        public virtual string Street { get; set; }
        public virtual string Province { get; set; }
        public virtual string Amphur { get; set; }
        public virtual string Tambon { get; set; }

        public virtual string ZipCode { get; set; }

        public virtual string PhoneNo { get; set; }
        public virtual string FaxNo { get; set; }
        public virtual string StayFromDate { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string PhoneOther { get; set; }

    }
}
