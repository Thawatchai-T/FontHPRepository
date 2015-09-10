using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class StatusViewModel
    {
        public int id { get; set; }
        public string Status {get;set;}
        public string Decription {get;set;}
        public DateTime InsertDate {get;set;}
        public string CreateUser {get;set;}
    }
}