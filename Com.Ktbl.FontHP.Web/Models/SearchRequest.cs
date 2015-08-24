using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class SearchRequest
    {
        public string StartDate { get; set; }
        public string Enddate { get; set; }

        public string RequestNo { get; set; }

        public string StatusRequest { get; set; }

        public string CitizenID { get; set; }

        public string Cusname { get; set; }

        public string Branch { get; set; }

    }
}