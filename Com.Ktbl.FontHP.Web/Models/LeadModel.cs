using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class LeadModel
    {
        public string LeadId { get; set; }
        public string LeadNo { get; set; }
        public string LeadStatus { get; set; }
        public string AdviserName { get; set; }
        public string AdviserSurName { get; set; }
        public string AdviserPosition { get; set; }
        public string AdviserTelOffice { get; set; }
        public string AdviserTelMobile { get; set; }
        public string AdviserFax { get; set; }
        public string AdviserEmail { get; set; }
        public string AdviserAddress { get; set; }
        public string AdviserProvinceName { get; set; }
        public string AdviserCardID { get; set; }
        //ข้อมูลลูกค้า
        public string CustomerAddress { get; set; }
        public string CustomerProvinceName { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerJuristicName { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerMobile { get; set; }

        public string CustomerEmail { get; set; }
        public string CustomerYearContact { get; set; }
        public string CustomerDebtLevel { get; set; }
        public string CustomerDebtLimit { get; set; }

        //ข้อมูลหน่วยงาน
        public string BranchCode { get; set; }
        public string BranchAddress { get; set; }
        public string BranchProvinceName { get; set; }
        public string BranchZipCode { get; set; }

        public string BranchAccountCode { get; set; }
        public string BranchTaxID { get; set; }
    }
}