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

        public List<GridComIns> GetGridComInsLoad()
        {
            List<GridComIns> list = new List<GridComIns>();

            list.Add(new GridComIns { DealerName="มาริวัน มากทรัพย์", PayCommissionTo="แก้วตา ดวงใจ", AbsorbTax= true, CommissionAmount=100.10, VAT = 5, AmountIncludeVAT=100.10, WithHoldTaxAmount= 200.10, NetPaid = 300.30     });
            list.Add(new GridComIns { DealerName = "ปทุม ใจดี", PayCommissionTo = "ฉัตรชัย มีเกิด", AbsorbTax = false, CommissionAmount = 200.10, VAT = 6, AmountIncludeVAT = 200.10, WithHoldTaxAmount = 300.10, NetPaid = 301.30 });
            list.Add(new GridComIns { DealerName = "ก้องฟ้า มีใจ", PayCommissionTo = "มาริตา ไม้หวาน", AbsorbTax = true, CommissionAmount = 300.10, VAT = 7, AmountIncludeVAT = 300.10, WithHoldTaxAmount = 400.10, NetPaid = 400.30 });
            list.Add(new GridComIns { DealerName = "มโนรา วายุ", PayCommissionTo = "ปกป้อง มีอยู่", AbsorbTax =false, CommissionAmount = 400.10, VAT = 8, AmountIncludeVAT = 400.10, WithHoldTaxAmount = 500.10, NetPaid = 500.30 });
            return list;
        }
    }
}
