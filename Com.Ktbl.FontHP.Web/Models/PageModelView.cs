using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class PageModelView<T>
    {
        public List<T> items { get; set; }
        public Int64 total { get; set; }
    }
}