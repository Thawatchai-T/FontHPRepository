using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class DataModel<T>
    {
        public bool success { get; set; }
        public T data { get; set; }

    }
}