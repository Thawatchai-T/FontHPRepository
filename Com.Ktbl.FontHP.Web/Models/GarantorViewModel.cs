using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Ktbl.FontHP.Web.Models
{
    public class GarantorViewModel
    {
        //add class Garantor
        public int id { get; set; }
        public string GuarCitizenID { get; set; }
        public string GuarTitleName { get; set; }

        public string GuarFNameTh { get; set; }

        public string GuarLNameTh { get; set; }
        public DateTime GuarBirthDate { get; set; }
        public int GuarAgeYear { get; set; }
        public int GuarAgeMonth { get; set; }
        public DateTime GuarExpiryDate { get; set; }
        public DateTime CitizenStartDate { get; set; }
        public string CitizenPlace { get; set; }
        public string GuarNationality { get; set; }
        public string GuarRace { get; set; }
        public string GuarGender { get; set; }
        public string RelativeDebtor { get; set; }
        public string GuarHomePhone { get; set; }
        public string GuarMobilePhone { get; set; }
        public string GuarResidentOwn { get; set; }
        public string GuarResidentOwnDetail { get; set; }
        public string GuarResidentStatus { get; set; }
        public int GuarResidentYear { get; set; }
        public int GuarResidentMonth { get; set; }
        public string GuarResidentRegStatus { get; set; }
        //อาชีพ
        public int GuarWorkPeriodAllYear { get; set; }
        public int GuarWorkPeriodAllMonth { get; set; }
        public int GuarWorkPeriodCurrentYear { get; set; }
        public int GuarWorkPeriodCurrentMonth { get; set; }
        public string GuarOfficePhone { get; set; }
        public string GuarOccupationType { get; set; }
        public string GuarOccupationGroup { get; set; }
        public string GuarOccupationCode { get; set; }
        public string GuarPosition { get; set; }
        public string OccPlace { get; set; }
        public string OccDetail { get; set; }

        //รายละเอียดคู่สมรส
        public string GuarMateName { get; set; }
        public string GuarMateOccupationGroup { get; set; }
        public string GuarMateOccPlace { get; set; }
        public double GuarMateIncome { get; set; }
        public string GuarMateOccPosition { get; set; }
        public string GuarMateWorkPeriod { get; set; }
        public string GuarMateTelephone { get; set; }
        public double MateExpense { get; set; }
        //เพิ่มจาก Grid
        public string NameGarantor { get; set; }

    }
}