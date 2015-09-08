using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class ComSpacialViewModel
    {
        public int id { get; set; }
        public string EmployeeName { get; set; }
        public string TypeAgent { get; set; }
        public string TypePromote { get; set; }
        public double Transfer { get; set; }
        public double Withholding { get; set; }
        public double AmountIncludeVAT { get; set; }

        public double LoanIncludeVAT { get; set; }
        public double VAT { get; set; }
        public double WHTAX { get; set; }
        public double NetPaid { get; set; }

        //design
        public string MarketingUserShow { get; set; }
        public string MarketingNameShow { get; set; }

        public string CitizenID { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public double PayLimitAmt01 { get; set; }
        public double PayLimitAmt03 { get; set; }
        public double PayLimitAmtVan { get; set; }
        public string PayCommissionTo { get; set; }
        public double CommissionAmount { get; set; }
        public double CommissionLoan { get; set; }
        public double ComTrsAmt { get; set; }
        public double CommissionTotal { get; set; }
        public double CommissionRate { get; set; }
        public double CommissionVAT { get; set; }
        public double WithHoldTaxAmount { get; set; }
      
      
      
        
     
    }
}