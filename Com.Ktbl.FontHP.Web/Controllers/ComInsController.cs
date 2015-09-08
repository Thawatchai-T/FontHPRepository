using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Web.Models;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class ComInsController : ApiController
    {
        #region Manage CommIns 20150908
      
        public PageModel<ComInsViewModel> GetComInsLoad()
        {
            List<ComInsViewModel> list = new List<ComInsViewModel>();
            var pagemodel = new PageModel<ComInsViewModel>();

            list.Add(new ComInsViewModel {id=1,DealerName = "มาริวัน มากทรัพย์", PayCommissionTo = "แก้วตา ดวงใจ", AbsorbTax = "01", CommissionAmount = 100.10, VAT = 5, AmountIncludeVAT = 100.10, WithHoldTaxAmount = 200.10, NetPaid = 300.30 });
            list.Add(new ComInsViewModel {id=2,DealerName = "ปทุม ใจดี", PayCommissionTo = "ฉัตรชัย มีเกิด", AbsorbTax = "02", CommissionAmount = 200.10, VAT = 6, AmountIncludeVAT = 200.10, WithHoldTaxAmount = 300.10, NetPaid = 301.30 });
            list.Add(new ComInsViewModel {id=3,DealerName = "ก้องฟ้า มีใจ", PayCommissionTo = "มาริตา ไม้หวาน", AbsorbTax = "01", CommissionAmount = 300.10, VAT = 7, AmountIncludeVAT = 300.10, WithHoldTaxAmount = 400.10, NetPaid = 400.30 });
            list.Add(new ComInsViewModel {id=4,DealerName = "มโนรา วายุ", PayCommissionTo = "ปกป้อง มีอยู่", AbsorbTax ="02", CommissionAmount = 400.10, VAT = 8, AmountIncludeVAT = 400.10, WithHoldTaxAmount = 500.10, NetPaid = 500.30 });
            pagemodel.items = list;
            pagemodel.total = 10;
            return pagemodel;
        }
        public Boolean Insert(ComInsViewModel obj)
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

        public ComInsViewModel GetComInsById(int id)
        {
            var result = new ComInsViewModel
            {
                id = 10,
                EntCodeShow = "00001",
                EntNameShow = "ใบเตย อิ่มอุ่น",
                CommissionAmount = 1.11,
                PayCommissionTo = "สารี แย้มงาม",
                VAT = 2.22,
                AbsorbTax = "01",
                WithHoldTaxAmount = 3.33,
                NetPaid = 4.44
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
