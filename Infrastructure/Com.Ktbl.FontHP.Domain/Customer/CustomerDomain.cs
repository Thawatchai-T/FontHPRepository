using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain.Customer
{
    public class CustomerDomain
    {
        public virtual string CustomerCode { get; set; }
        public virtual string CustomerGroup { get; set; }
        public virtual string Titlename { get; set; }
        public virtual string FNameEng { get; set; }
        public virtual string LNameEng { get; set; }
        public virtual string FNameThai { get; set; }
        public virtual string LNameThai { get; set; }
        public virtual string CustNature { get; set; }
        public virtual string Contactname { get; set; }
        public virtual string Email { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Bot { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual string ProvinceCode { get; set; }
        public virtual string Sex { get; set; }
        public virtual string Marriage { get; set; }
        public virtual DateTime? StartWorkDate { get; set; }
        public virtual string OccupationGroup { get; set; }
        public virtual string Occupation { get; set; }
        public virtual string Officeaddress { get; set; }
        public virtual string Positions { get; set; }
        public virtual string PositionCode { get; set; }
        public virtual string StartDate { get; set; }
        public virtual double? Salary { get; set; }
        public virtual string PayBy { get; set; }
        public virtual int? DwellLong { get; set; }
        public virtual string Typehost { get; set; }
        public virtual double? Rent { get; set; }
        public virtual double? Deub { get; set; }
        public virtual string Hrname { get; set; }
        public virtual string Hrtelephone { get; set; }
        public virtual string Lastcompanyname { get; set; }
        public virtual string Lastpositionname { get; set; }
        public virtual string Lasttelephone { get; set; }
        public virtual int? Lastage { get; set; }
        public virtual int? EducationOfSon { get; set; }
        public virtual string SpouseName { get; set; }
        public virtual string SpouseOccupation { get; set; }
        public virtual string SpouseCompany { get; set; }
        public virtual string SpousePosition { get; set; }
        public virtual double? SpouseSalary { get; set; }
        public virtual double? SpouseDeub { get; set; }
        public virtual string SpouseTelephone { get; set; }
        public virtual int? SpouseAge { get; set; }
        public virtual string Typecard { get; set; }
        public virtual string Idcode { get; set; }
        public virtual DateTime? IssuedDate { get; set; }
        public virtual DateTime? ExpriedDate { get; set; }
        public virtual string IssuedBy { get; set; }
        public virtual string Bank { get; set; }
        public virtual string AccountType { get; set; }
        public virtual string AccountNo { get; set; }
        public virtual int? AccountLife { get; set; }
        public virtual int? AccountOutstanding { get; set; }
        public virtual int? AccountOverbal { get; set; }
        public virtual string Bank1 { get; set; }
        public virtual double? BankDeb1 { get; set; }
        public virtual string Bank2 { get; set; }
        public virtual double? BankDeb2 { get; set; }
        public virtual string Bank3 { get; set; }
        public virtual double? BankDeb3 { get; set; }
        public virtual string CalculateBy { get; set; }
        public virtual double? FinanceSalaryAmt { get; set; }
        public virtual int? FinanceSalaryMonth { get; set; }
        public virtual double? FinanceSalaryPercent { get; set; }
        public virtual double? FinanceSalaryNet { get; set; }
        public virtual double? FinanceBonusAmt { get; set; }
        public virtual int? FinanceBonusMonth { get; set; }
        public virtual double? FinanceBonusPercent { get; set; }
        public virtual double? FinanceBonusNet { get; set; }
        public virtual double? FinanceCommAmt { get; set; }
        public virtual int? FinanceCommMonth { get; set; }
        public virtual double? FinanceCommPercent { get; set; }
        public virtual double? FinanceCommNet { get; set; }
        public virtual double? FinanceOthAmt { get; set; }
        public virtual int? FinanceOthMonth { get; set; }
        public virtual double? FinanceOthPercent { get; set; }
        public virtual double? FinanceOthNet { get; set; }
        public virtual string OtherIncome { get; set; }
        public virtual double? DebRentHouse { get; set; }
        public virtual double? DebHouse { get; set; }
        public virtual double? DebLeaseCar { get; set; }
        public virtual double? DebOth { get; set; }
        public virtual double? TotalIncome { get; set; }
        public virtual double? TotalDeb { get; set; }
        public virtual double? TotalIncomeDeb { get; set; }
        public virtual double? TotalPercent { get; set; }
        public virtual bool? Posted { get; set; }
        public virtual string Entcode { get; set; }
        public virtual string Remark1 { get; set; }
        public virtual string Remark2 { get; set; }
        public virtual string Remark3 { get; set; }
        public virtual string Remark4 { get; set; }
        public virtual string Remark5 { get; set; }
        public virtual double? DocIncome { get; set; }
        public virtual double? StatementIncome { get; set; }
        public virtual bool? KtbsalaryFlag { get; set; }
        public virtual string KtbAccno { get; set; }
        public virtual string Department { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual bool? Active { get; set; }
        public virtual string FinanceGrp { get; set; }
        public virtual string Webposition { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string OccDetail { get; set; }
        public virtual string CareerId { get; set; }
        public virtual string GroupId { get; set; }
        public virtual string Parentcompany { get; set; }
    }
}
