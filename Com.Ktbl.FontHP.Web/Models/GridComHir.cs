using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    //
    public class GridComHir
    {
       //hide public string EmployeeName { get; set; }
        public string DealerName { get; set; }

        public string PayCommissionTo { get; set; }

        public bool AbsorbTax { get; set; }

        public double CommissionRate { get; set; }

        public double MaxRate { get; set; }

        public double CommissionTerm { get; set; }

        public int MaxTerm { get; set; }

        public double CommissionVATNo { get; set; }

        public double InterestRate { get; set; }

        public DateTime CommissionVATDate { get; set; }

        public double HiringChargeIncludeVAT { get; set; }

        public double AmountVAT { get; set; }

        public double AmountIncludeVAT { get; set; }

        public double WithHoldTaxAmount { get; set; }

        public double NetPaid { get; set; }

        public double StandardInterestRate { get; set; }

        public string Campaign { get; set; }

        

    }
    
}