using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Ktbl.FontHP.Domain
{
  public class LeadHeaderDomain
    {
        public virtual string LeadNo { get; set; }
        public virtual DateTime  LeadDate { get; set; }

        public virtual string AdviserCode { get; set; }

        public virtual string AdviserName { get; set; }

        public virtual string AdviserSurName { get; set; }

        public virtual string AdviserPositions { get; set; }

        public virtual string AdviserTelOffice { get; set; }

        public virtual string AdviserTelMobile { get; set; }

        public virtual string AdviserFaxOffice { get; set; }

        public virtual string AdviserEMail { get; set; }

        public virtual string AdviserAddress1 { get; set; }

        public virtual string AdviserAddress2 { get; set; }

        public virtual string AdviserAddress3 { get; set; }

        public virtual string AdviserAddress4 { get; set; }

        public virtual string AdviserProvinceName { get; set; }

        public virtual string AdviserCardId { get; set; }

        public virtual string AdviserTaxId { get; set; }

        public virtual string AdviserAccCode { get; set; }

        public virtual string BranchCode { get; set; }

        public virtual string BranchName { get; set; }

        public virtual string BranchTaxId { get; set; }

        public virtual string BranchAccCode { get; set; }

        public virtual string BranchAddress1 { get; set; }

        public virtual string BranchAddress2 { get; set; }

        public virtual string BranchAddress3 { get; set; }

        public virtual string BranchAddress4 { get; set; }

        public virtual string BranchProvinceName { get; set; }

        public virtual string BranchZip { get; set; }

        public virtual string CustomerTitle { get; set; }

        public virtual string CustomerName { get; set; }

        public virtual string CustomerSurName { get; set; }

        public virtual string CustomerAddress1 { get; set; }

        public virtual string CustomerAddress2 { get; set; }

        public virtual string CustomerProvinceId { get; set; }

        public virtual string CustomerZip { get; set; }

        public virtual string CustomerJuristicName { get; set; }

        public virtual string CustomerTel { get; set; }

        public virtual string CustomerMobile { get; set; }

        public virtual string CustomerEMail { get; set; }

        public virtual string CustomerYearContact { get; set; }

        public virtual string CustomerDebtLevel { get; set; }

        public virtual string CustomerId { get; set; }

        public virtual DateTime  SendDate { get; set; }

        public virtual DateTime  ReplyDate { get; set; }

        public virtual string MarketingCode { get; set; }

        public virtual string LeadRemark { get; set; }

        public virtual DateTime  CreateDate { get; set; }

        public virtual string CreateUser { get; set; }

        public virtual DateTime  ModifyDate { get; set; }

        public virtual string ModifyUser { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string MarketingCreateUser { get; set; }

        public virtual DateTime  MarketingCreateDate { get; set; }

        public virtual DateTime  MarketingAsignDate { get; set; }

        public virtual string ProductCode { get; set; }

        public virtual decimal  BankAmt { get; set; }

        public virtual bool FlagComm { get; set; }

        public virtual string FLAssetAccNo { get; set; }

        public virtual string FLAssetNo { get; set; }

        public virtual string FLAssetRemark { get; set; }

        public virtual string CustomerCreditRemark { get; set; }

        public virtual decimal  ApproveAmt { get; set; }

        public virtual DateTime  ApproveDate { get; set; }

        public virtual string CustomerType { get; set; }

        public virtual string AdviserRemark { get; set; }

        public virtual string CustomerFax { get; set; }

        public virtual bool IsSp { get; set; }

        public virtual string MarketingVPCODE { get; set; }

        public virtual DateTime  MarketingVPAssignDate { get; set; }

        public virtual string MarketingVPFlag { get; set; }

        public virtual string MarketingVPAssignRemark { get; set; }

        public virtual string CareerGroup { get; set; }

        public virtual string PositionName { get; set; }

        public virtual string Companyname { get; set; }

        public virtual string NetIncome { get; set; }

        public virtual string AgeWork { get; set; }

        public virtual string ProductType { get; set; }

        public virtual string BrandCar { get; set; }

        public virtual string CarType { get; set; }

        public virtual string MonthDown { get; set; }

        public virtual string TimePay { get; set; }

        public virtual string Interest { get; set; }

        public virtual DateTime  DateUse { get; set; }

        public virtual string Other { get; set; }

        public virtual decimal  AllTotal { get; set; }

        public virtual DateTime  DateAction { get; set; }

        public virtual string PropertyType { get; set; }

        public virtual string Credit { get; set; }

        public virtual string DataBy { get; set; }

        public virtual string CustomerOccu { get; set; }

        public virtual decimal  CustomerIncome { get; set; }

        public virtual string CustomerCarType { get; set; }

        public virtual string CustomerCarBrand { get; set; }

        public virtual string CustomerAsset { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as LeadHeaderDomain;
            if (t == null) return false;
            if (LeadNo == t.LeadNo)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ LeadNo.GetHashCode();
            return hash;
        }
        #endregion
    }
}
