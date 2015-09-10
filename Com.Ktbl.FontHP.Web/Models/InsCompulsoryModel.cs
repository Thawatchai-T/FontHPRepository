using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class InsCompulsoryModel
    {
        public string CompusaryInsCompany { get; set; }
        public string SSType { get; set; }
        public string PrbPoicy { get; set; }
        public DateTime CompusaryStart { get; set; }
        public DateTime CompusaryEnd { get; set; }
        public double SSPrb { get; set; }
        public string WHStatutes { get; set; }
        public double CompusaryStamp { get; set; }
        public double CompusaryFee { get; set; }
        public double SSWih { get; set; }
        public string Campaign { get; set; }
        public double Comm { get; set; }
        public double Discount { get; set; }
        public double Promotion { get; set; }
        public double PromotionDiscount { get; set; }

    }
}