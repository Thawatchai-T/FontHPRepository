using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    //add class p2p
    public class GuiPopupCusAddress
    {
        public string CutomerType { get; set; }
        public string AddressType { get; set; }
        public string RegistNo { get; set; }
        public string AddressNo { get; set; }
        public string Moo { get; set; }
        public string MooBaan { get; set; }
        public string Soi { get; set; }
        public string Street { get; set; }
        public string Province { get; set; }
        public string Amphur { get; set; }
        public string Tambon { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime StayFromDate { get; set; }
        public string Mobile { get; set; }
        public string PhoneOther { get; set; }
        public int id { get; set; }
       
    }
}