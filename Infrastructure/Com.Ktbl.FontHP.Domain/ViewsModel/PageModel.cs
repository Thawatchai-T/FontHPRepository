using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.ViewsModel
{
    public class PageModel<T>
    {
        public List<T> items { get; set; }
        public Int64 total { get; set; }
    }
}
