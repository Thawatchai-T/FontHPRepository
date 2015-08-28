using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Web.Models;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CommisionController : ApiController
    {
        public List<GridComHir> GetGridComhiringLoad()
        {
            List<GridComHir> list = new List<GridComHir>();

            list.Add(new GridComHir { DealerName = "แมกไม้ ผลดี", PayCommissionTo = "เกริกกล้า แก้วใจ", AbsorbTax = true, CommissionRate = 100.12, MaxRate = 11.10, CommissionTerm = 10.12, MaxTerm = 10 , CommissionVATNo = 200.10, InterestRate = 300.20, CommissionVATDate =  Convert.ToDateTime("17-07-2015"), HiringChargeIncludeVAT= 400.30, AmountVAT = 500.40, AmountIncludeVAT = 600.50, WithHoldTaxAmount = 700.60, NetPaid = 800.70, StandardInterestRate = 900.80, Campaign = "Campaign1"});
            list.Add(new GridComHir { DealerName = "อิ่มเอิบ เกิดกลาย", PayCommissionTo = "ทิพวรรณ นำคุณ", AbsorbTax = false, CommissionRate = 200.12, MaxRate = 12.20, CommissionTerm = 20.12, MaxTerm = 20, CommissionVATNo = 300.10, InterestRate = 400.20, CommissionVATDate = Convert.ToDateTime("10-07-2015"), HiringChargeIncludeVAT = 500.30, AmountVAT = 600.40, AmountIncludeVAT = 700.50, WithHoldTaxAmount = 800.60, NetPaid = 900.70, StandardInterestRate = 1000.80, Campaign = "Campaign2" });
            list.Add(new GridComHir { DealerName = "สินทรัพย์ ผลดี", PayCommissionTo = "ภาสิทธิ์ อิ่มใจ", AbsorbTax = true, CommissionRate = 300.12, MaxRate = 13.30, CommissionTerm = 30.12, MaxTerm = 30, CommissionVATNo = 400.10, InterestRate = 500.20, CommissionVATDate = Convert.ToDateTime("7-06-2015"), HiringChargeIncludeVAT = 600.30, AmountVAT = 700.40, AmountIncludeVAT = 800.50, WithHoldTaxAmount = 900.60, NetPaid = 1000.70, StandardInterestRate = 1100.80, Campaign = "Campaign3" });
            return list;
        }
    }
}
