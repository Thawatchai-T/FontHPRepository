using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Web.Models;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class ComSpacialController : ApiController
    {

        #region Manage CommSpac 20150908

        public PageModel<ComSpacialViewModel> GetComSpacialLoad()
        {
            List<ComSpacialViewModel> list = new List<ComSpacialViewModel>();
            var pagemodel = new PageModel<ComSpacialViewModel>();

            list.Add(new ComSpacialViewModel { id = 1, EmployeeName = "มาริวัน มากทรัพย์", PayCommissionTo = "แก้วตา ดวงใจ", TypeAgent = "จำหน่าย 1", TypePromote = "Promote 1", Transfer = 10.11, Withholding = 11.11, VAT = 5, AmountIncludeVAT = 100.10, LoanIncludeVAT = 200.10, WHTAX = 300.30, NetPaid = 55.30 });
            list.Add(new ComSpacialViewModel { id = 2, EmployeeName = "ปทุม ใจดี", PayCommissionTo = "ฉัตรชัย มีเกิด", TypeAgent = "จำหน่าย 2", TypePromote = "Promote 2", Transfer = 20.11, Withholding = 21.11, VAT = 6, AmountIncludeVAT = 200.10, LoanIncludeVAT = 300.10, WHTAX = 301.30, NetPaid = 66.30 });
            list.Add(new ComSpacialViewModel { id = 3, EmployeeName = "ก้องฟ้า มีใจ", PayCommissionTo = "มาริตา ไม้หวาน", TypeAgent = "จำหน่าย 3", TypePromote = "Promote 3", Transfer = 30.11, Withholding = 31.11, VAT = 7, AmountIncludeVAT = 300.10, LoanIncludeVAT = 400.10, WHTAX = 400.30, NetPaid = 77.30 });
            list.Add(new ComSpacialViewModel { id = 4, EmployeeName = "มโนรา วายุ", PayCommissionTo = "ปกป้อง มีอยู่", TypeAgent = "จำหน่าย 4", TypePromote = "Promote 4", Transfer = 40.11, Withholding = 41.11, VAT = 8, AmountIncludeVAT = 400.10, LoanIncludeVAT = 500.10, WHTAX = 500.30, NetPaid = 88.30 });
            pagemodel.items = list;
            pagemodel.total = 10;
            return pagemodel;
        }
        public Boolean Insert(ComSpacialViewModel obj)
        {

            if (obj.id != null)
            {
                //Update
            }
            else
            {
                //Insert
            }

            return true;
        }

        public ComSpacialViewModel GetComSpacialById(int id)
        {
            var result = new ComSpacialViewModel
            {
                id = 10,
                MarketingUserShow = "00001",
                MarketingNameShow = "มีนา มาดี",
                CitizenID = "1111111111119",
                BankName = "กสิกร",
                BranchName = "สำนักงานใหญ่",
                AccountNo = "333333",
                //จำนวนเงินที่จ่าย
                PayLimitAmt01 = 1.10,
                PayLimitAmt03 = 2.20,
                PayCommissionTo = "ชบา บัวยิ่ง",
                CommissionAmount = 3.30,
                CommissionLoan = 4.40,
                ComTrsAmt = 5.50,
                CommissionTotal = 6.60,
                CommissionRate = 7.70,
                CommissionVAT = 8.80,
                AmountIncludeVAT = 9.90,
                LoanIncludeVAT = 11.10,
                WithHoldTaxAmount = 12.20,
                NetPaid = 13.30,
                
            };
            return result;
        }

        public void Delete(int id)
        {
            //TODO:  not implement
        }
        #endregion
      
        

    }
}
