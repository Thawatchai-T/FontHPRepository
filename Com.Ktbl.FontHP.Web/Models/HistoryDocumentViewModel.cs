using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class HistoryDocumentViewModel
    {
        public int id { get; set; }
        public string RequestNo { get; set; }
        public DateTime RequestDate { get; set; }
        public string CitizenId { get; set; }
        public string CusName { get; set; }
        public string NCBStatus { get; set; }
        public string RequestStatus { get; set; }
        
    }
}