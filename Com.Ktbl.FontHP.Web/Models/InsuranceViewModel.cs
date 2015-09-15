using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Com.Ktbl.FontHP.Web.Models;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class InsuranceViewModel
    {

        public InsuranceModel InsuranceModel { get; set; }
        public InsCompulsoryModel CompulsoryModel { get; set; }
        public InsLoanProtectionModel LoanProtectionModel { get; set; }

       public  InsuranceViewModel()
        {
            InsuranceModel = new InsuranceModel();
            InsuranceModel.Customer = "สมควร";
            InsuranceModel.ConditionInsurance = "มีนา คนดี";
            InsuranceModel.RequestNo = 1;
            //objIns.InsuranceCompany = "มีนา คนดี";
            //objIns.NoticeNo = "มีนา คนดี";
            //objIns.NoticeBy = "มีนา คนดี";
            //objIns.NotiDate = Convert.ToDateTime("17-04-2000");
            //objIns.PoicyNo = "มีนา คนดี";
            //objIns.SSStart = "มีนา คนดี";
            //objIns.SSEnd = "มีนา คนดี";
            //objIns.SSCost = "มีนา คนดี";
            //objIns.SSFee = "มีนา คนดี";
            //objIns.WHInsFee = "มีนา คนดี";
            //objIns.Stamp = "มีนา คนดี";
            //objIns.SSFeeCoect = "มีนา คนดี";
            //objIns.Deduct = "มีนา คนดี";
            //objIns.Driver = "มีนา คนดี";
            //objIns.WhereRepair = "มีนา คนดี";
            //objIns.DriverName1 = "มีนา คนดี";
            //objIns.DriverBirth1 = "มีนา คนดี";
            //objIns.DrivingC1 = "มีนา คนดี";
            //objIns.DriverName2 = "มีนา คนดี";
            //objIns.DriverBirth2 = "มีนา คนดี";
            //objIns.DrivingC2 = "มีนา คนดี";
            //objIns.SSCampaign = "มีนา คนดี";
            //objIns.SSComm = "มีนา คนดี";
            //objIns.SSDiscount = "มีนา คนดี";
            //objIns.SSPromotionDiscount = "มีนา คนดี";
           //prb
            //objIns.CompusaryInsCompany = "ทืพยประกันภัย";
            //objIns.SSType = "มีนา คนดี";
            //objIns.PrbPoicy = "มีนา คนดี";
            //objIns.CompusaryStart = "มีนา คนดี";
            //objIns.CompusaryEnd = "มีนา คนดี";
            //objIns.SSPrb = "มีนา คนดี";
            //objIns.WHStatutes = "มีนา คนดี";
            //objIns.CompusaryStamp = "มีนา คนดี";
            //objIns.CompusaryFee = "มีนา คนดี";
            //objIns.SSWih = "มีนา คนดี";
            //objIns.Campaign = "มีนา คนดี";
            //objIns.Comm = "มีนา คนดี";
            //objIns.Discount = "มีนา คนดี";
            //objIns.Promotion = "มีนา คนดี";
            //objIns.PromotionDiscount = "มีนา คนดี";
           //Loan
            //objIns.LoanProtectPoicyNo = "มีนา คนดี";
            //objIns.LoanProtectStart = "มีนา คนดี";
            //objIns.LoanProtectEnd = "มีนา คนดี";
            //objIns.Promotion = "มีนา คนดี";
            //objIns.Promotion = "มีนา คนดี";
            //objIns.Promotion = "มีนา คนดี";



            CompulsoryModel = new InsCompulsoryModel();
            CompulsoryModel.CompusaryInsCompany = "bar";
            CompulsoryModel.PrbPoicy = "foo";
            this.CompulsoryModel.RequestNo = 1;
            LoanProtectionModel = new InsLoanProtectionModel();
            this.LoanProtectionModel.RequestNo = 1;
        }
      
    }
}