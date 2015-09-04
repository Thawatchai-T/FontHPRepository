using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class CardTypeViewModel
    {
        public int id { get; set; }
        public string TypeCard { get; set; }
        public string CardNo { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime IssueDate { get; set; }
        
    }
}