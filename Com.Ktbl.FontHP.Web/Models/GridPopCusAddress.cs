using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class GridPopCusAddress
    {
        //add class 20150901
        public int id { get; set; }
        public string AddressType { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public DateTime LiveFrom { get; set; }
    }
}