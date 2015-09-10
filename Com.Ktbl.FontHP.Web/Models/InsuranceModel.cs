using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class InsuranceModel
    {
        public string Customer { get; set; }
        public string InsuranceBy { get; set; }
        public string ConditionInsurance { get; set; }
        public string InsuranceCompany { get; set; }
        public string NoticeNo { get; set; }
        public string NoticeBy { get; set; }
        public DateTime NotiDate { get; set; }
        public string PoicyNo { get; set; }
        public DateTime SSStart { get; set; }
        public DateTime SSEnd { get; set; }
        public double SSCost { get; set; }
        public double SSFee { get; set; }
        public double WHInsFee { get; set; }
        public double Stamp { get; set; }
        public double SSFeeCoect { get; set; }
        public string Deduct { get; set; }
        public string Driver { get; set; }
        public string WhereRepair { get; set; }
        public string DriverName1 { get; set; }
        public DateTime DriverBirth1 { get; set; }
        public string DrivingC1 { get; set; }
        public string DriverName2 { get; set; }
        public DateTime DriverBirth2 { get; set; }
        public string DrivingC2 { get; set; }
        public string SSCampaign { get; set; }
        public double SSComm { get; set; }
        public double SSDiscount { get; set; }
        public double SSPromotion { get; set; }
        public double SSPromotionDiscount { get; set; }
        ////prb
        //public string CompusaryInsCompany { get; set; }
        //public string SSType { get; set; }
        //public string PrbPoicy { get; set; }
        //public DateTime CompusaryStart { get; set; }
        //public DateTime CompusaryEnd { get; set; }
        //public double SSPrb { get; set; }
        //public string WHStatutes { get; set; }
        //public double CompusaryStamp { get; set; }
        //public double CompusaryFee { get; set; }
        //public double SSWih { get; set; }
        //public string Campaign { get; set; }
        //public double Comm { get; set; }
        //public double Discount { get; set; }
        //public double Promotion { get; set; }
        //public double PromotionDiscount { get; set; }
         
        ////Loan
        //public string LoanProtectPoicyNo { get; set; }
        //public DateTime LoanProtectStart { get; set; }
        //public DateTime LoanProtectEnd { get; set; }
        //public string LoanProtectNo { get; set; }
        //public DateTime LoanProtectRequestDate { get; set; }
        //public string RejectReason { get; set; }

        
    }
}