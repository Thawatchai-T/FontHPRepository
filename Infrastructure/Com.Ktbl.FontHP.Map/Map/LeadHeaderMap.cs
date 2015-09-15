using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    class LeadHeaderMap : ClassMap<LeadHeaderDomain>
    {

        public LeadHeaderMap()
        {
            Table("Lead_Header");
            LazyLoad();
            CompositeId().KeyProperty(x => x.LeadNo, "Lead_No");
            Map(x => x.LeadDate).Column("Lead_Date");
            Map(x => x.AdviserCode).Column("Adviser_Code");
            Map(x => x.AdviserName).Column("Adviser_Name");
            Map(x => x.AdviserSurName).Column("Adviser_SurName");
            Map(x => x.AdviserPositions).Column("Adviser_Positions");
            Map(x => x.AdviserTelOffice).Column("Adviser_Tel_Office");
            Map(x => x.AdviserTelMobile).Column("Adviser_Tel_Mobile");
            Map(x => x.AdviserFaxOffice).Column("Adviser_Fax_Office");
            Map(x => x.AdviserEMail).Column("Adviser_E_Mail");
            Map(x => x.AdviserAddress1).Column("Adviser_Address1");
            Map(x => x.AdviserAddress2).Column("Adviser_Address2");
            Map(x => x.AdviserAddress3).Column("Adviser_Address3");
            Map(x => x.AdviserAddress4).Column("Adviser_Address4");
            Map(x => x.AdviserProvinceName).Column("Adviser_ProvinceName");
            Map(x => x.AdviserCardId).Column("Adviser_CardId");
            Map(x => x.AdviserTaxId).Column("Adviser_TaxId");
            Map(x => x.AdviserAccCode).Column("Adviser_AccCode");
            Map(x => x.BranchCode).Column("Branch_Code");
            Map(x => x.BranchName).Column("Branch_Name");
            Map(x => x.BranchTaxId).Column("Branch_TaxId");
            Map(x => x.BranchAccCode).Column("Branch_AccCode");
            Map(x => x.BranchAddress1).Column("Branch_Address1");
            Map(x => x.BranchAddress2).Column("Branch_Address2");
            Map(x => x.BranchAddress3).Column("Branch_Address3");
            Map(x => x.BranchAddress4).Column("Branch_Address4");
            Map(x => x.BranchProvinceName).Column("Branch_ProvinceName");
            Map(x => x.BranchZip).Column("Branch_Zip");
            Map(x => x.CustomerTitle).Column("Cust_Title");
            Map(x => x.CustomerName).Column("Cust_Name");
            Map(x => x.CustomerSurName).Column("Cust_SurName");
            Map(x => x.CustomerAddress1).Column("Cust_Address1");
            Map(x => x.CustomerAddress2).Column("Cust_Address2");
            Map(x => x.CustomerProvinceId).Column("Cust_ProvinceId");
            Map(x => x.CustomerZip).Column("Cust_Zip");
            Map(x => x.CustomerJuristicName).Column("Cust_JuristicName");
            Map(x => x.CustomerTel).Column("Cust_Tel");
            Map(x => x.CustomerMobile).Column("Cust_Mobile");
            Map(x => x.CustomerEMail).Column("Cust_E_Mail");
            Map(x => x.CustomerYearContact).Column("Cust_YearContact");
            Map(x => x.CustomerDebtLevel).Column("Cust_DebtLevel");
            Map(x => x.CustomerId).Column("Cust_ID");
            Map(x => x.SendDate).Column("Send_Date");
            Map(x => x.ReplyDate).Column("Reply_Date");
            Map(x => x.MarketingCode).Column("Mkt_Code");
            Map(x => x.LeadRemark).Column("Lead_Remark");
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User");
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User");
            Map(x => x.IsActive).Column("Active");
            Map(x => x.MarketingCreateUser).Column("Mkt_Create_User");
            Map(x => x.MarketingCreateDate).Column("Mkt_Create_Date");
            Map(x => x.MarketingAsignDate).Column("Mkt_Asign_Date");
            Map(x => x.ProductCode).Column("Product_Code");
            Map(x => x.BankAmt).Column("Bank_Amt");
            Map(x => x.FlagComm).Column("FlagComm");
            Map(x => x.FLAssetAccNo).Column("FLAsset_AccNo");
            Map(x => x.FLAssetNo).Column("FLAsset_No");
            Map(x => x.FLAssetRemark).Column("FLAsset_Remark");
            Map(x => x.CustomerCreditRemark).Column("Cust_CreditRemark");
            Map(x => x.ApproveAmt).Column("Approve_Amt");
            Map(x => x.ApproveDate).Column("Approve_Date");
            Map(x => x.CustomerType).Column("Cust_Type");
            Map(x => x.AdviserRemark).Column("Adviser_Remark");
            Map(x => x.CustomerFax).Column("Cust_Fax");
            Map(x => x.IsSp).Column("Is_SP");
            Map(x => x.MarketingVPCODE).Column("Mkt_VP_CODE");
            Map(x => x.MarketingVPAssignDate).Column("Mkt_VP_Assign_Date");
            Map(x => x.MarketingVPFlag).Column("Mkt_VP_Flag");
            Map(x => x.MarketingVPAssignRemark).Column("Mkt_VP_Assign_Remark");
            Map(x => x.CareerGroup).Column("CareerGroup");
            Map(x => x.PositionName).Column("PositionName");
            Map(x => x.Companyname).Column("Companyname");
            Map(x => x.NetIncome).Column("NetIncome");
            Map(x => x.AgeWork).Column("AgeWork");
            Map(x => x.ProductType).Column("ProductType");
            Map(x => x.BrandCar).Column("BrandCar");
            Map(x => x.CarType).Column("CarType");
            Map(x => x.MonthDown).Column("MonthDown");
            Map(x => x.TimePay).Column("TimePay");
            Map(x => x.Interest).Column("Interest");
            Map(x => x.DateUse).Column("DateUse");
            Map(x => x.Other).Column("Other");
            Map(x => x.AllTotal).Column("AllTotal");
            Map(x => x.DateAction).Column("DateAction");
            Map(x => x.PropertyType).Column("PropertyType");
            Map(x => x.Credit).Column("Credit");
            Map(x => x.DataBy).Column("Data_By");
            Map(x => x.CustomerOccu).Column("Cust_Occu");
            Map(x => x.CustomerIncome).Column("Cust_Income");
            Map(x => x.CustomerCarType).Column("Cust_CarType");
            Map(x => x.CustomerCarBrand).Column("Cust_CarBrand");
            Map(x => x.CustomerAsset).Column("Cust_Asset");
           
        }
    }
}

