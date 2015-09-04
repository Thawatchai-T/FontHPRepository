using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Com.Ktbl.FontHP.Web.Models
{
    //add class 20150828
    public class GridGarantor
    {
        public string GuarCitizenID { get; set; }
        public string NameGarantor { get; set; }

        public string RelativeDebtor { get; set; }

        public DateTime GuarBirthDate { get; set; }

        public string GuarHomePhone { get; set; }
    }
}