using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class GridComIns
    {
        public string DealerName { get; set; }
        public string PayCommissionTo { get; set; }
        public bool AbsorbTax { get; set; }
        public double CommissionAmount { get; set; }
        public double VAT { get; set; }
        public double AmountIncludeVAT { get; set; }

        public double WithHoldTaxAmount { get; set; }

        public double NetPaid { get; set; }

    }
}