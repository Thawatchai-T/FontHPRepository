using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Web.Models;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class ComHiringController : ApiController
    {
        //
        // GET: /ComHiring/

        #region Manage Commision 20150908
        public PageModel<ComHirViewModel> GetComhiringLoad()
        {
            List<ComHirViewModel> list = new List<ComHirViewModel>();
            var pagemodel = new PageModel<ComHirViewModel>();

            list.Add(new ComHirViewModel { id=1,DealerName = "แมกไม้ ผลดี", PayCommissionTo = "เกริกกล้า แก้วใจ", AbsorbTax = "01", CommissionRate = 100.12, MaxRate = 11.10, CommissionTerm = 10.12, MaxTerm = 10, CommissionVATNo = 200.10, InterestRate = 300.20, CommissionVATDate = Convert.ToDateTime("17-07-2015"), HiringChargeIncludeVAT = 400.30, AmountVAT = 500.40, AmountIncludeVAT = 600.50, WithHoldTaxAmount = 700.60, NetPaid = 800.70, StandardInterestRate = 900.80, Campaign = "Campaign1" });
            list.Add(new ComHirViewModel { id=2,DealerName = "อิ่มเอิบ เกิดกลาย", PayCommissionTo = "ทิพวรรณ นำคุณ", AbsorbTax = "02", CommissionRate = 200.12, MaxRate = 12.20, CommissionTerm = 20.12, MaxTerm = 20, CommissionVATNo = 300.10, InterestRate = 400.20, CommissionVATDate = Convert.ToDateTime("10-07-2015"), HiringChargeIncludeVAT = 500.30, AmountVAT = 600.40, AmountIncludeVAT = 700.50, WithHoldTaxAmount = 800.60, NetPaid = 900.70, StandardInterestRate = 1000.80, Campaign = "Campaign2" });
            list.Add(new ComHirViewModel { id=3,DealerName = "สินทรัพย์ ผลดี", PayCommissionTo = "ภาสิทธิ์ อิ่มใจ", AbsorbTax = "01", CommissionRate = 300.12, MaxRate = 13.30, CommissionTerm = 30.12, MaxTerm = 30, CommissionVATNo = 400.10, InterestRate = 500.20, CommissionVATDate = Convert.ToDateTime("7-06-2015"), HiringChargeIncludeVAT = 600.30, AmountVAT = 700.40, AmountIncludeVAT = 800.50, WithHoldTaxAmount = 900.60, NetPaid = 1000.70, StandardInterestRate = 1100.80, Campaign = "Campaign3" });

            pagemodel.items = list;
            pagemodel.total = 10;
            return pagemodel;
        }
        public Boolean Insert(ComHirViewModel obj)
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

        public ComHirViewModel GetComHirById(int id)
        {
            var result = new ComHirViewModel
            {
                id = 10,
                WHTaxCorporation = 1.10,
                WHTaxIndividual = 2.20,
                MaximumCommission = 3.00,
                DeductionRate = 4.00,
                EntCodeShow = "00001",
                EntNameShow = "สายใจ สุดใจ",
                HiringChargeIncludeVAT = 3.00,
                PayCommissionTo = "สายหยุด",
                AmountVAT = 4.00,
                AbsorbTax = "01",
                AmountIncludeVAT = 5.00,
                CommissionRate = 6.00,
                MaxRate = 7.00,
                WithHoldTaxAmount = 8.00,
                CommissionTerm = 9.00,
                MaxTerm = 5,
                NetPaid = 10.00,
                CommissionVATNo = 11.00,
                InterestRate = 12.00,
                CommissionVATDate = Convert.ToDateTime("07-06-2015"),
                //Low
                LowInterestRate = 13.00,
                CampaignName = "ชื่อ Campaing"
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
