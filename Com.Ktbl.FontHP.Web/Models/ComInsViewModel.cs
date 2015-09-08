using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class ComInsViewModel
    {
        public int id { get; set; }
        public string DealerName { get; set; }
        public string PayCommissionTo { get; set; }
        public string AbsorbTax { get; set; }
        public double CommissionAmount { get; set; }
        public double VAT { get; set; }
        public double AmountIncludeVAT { get; set; }

        public double WithHoldTaxAmount { get; set; }

        public double NetPaid { get; set; }
        
        //desing 20150908
        public string EntCodeShow { get; set; }
        public string EntNameShow { get; set; }
    }
}