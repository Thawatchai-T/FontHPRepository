using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Web.Models;
namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class GarantorController : ApiController
    {
        //add controlller for garantor 20150828
        public List<GarantorViewModel> GetGridGarantorLoad(int start, int limit, int page) 
        {
            List<GarantorViewModel> list = new List<GarantorViewModel>();

            list.Add(new GarantorViewModel { GuarCitizenID = "1111111111119", NameGarantor = "จารุวรรณ มากมี", RelativeDebtor = "คู่สมรส", GuarBirthDate = Convert.ToDateTime("17-04-2000"), GuarHomePhone = "035-023887" });
            list.Add(new GarantorViewModel { GuarCitizenID = "1111111111118", NameGarantor = "มารุต ปานทุ่ม", RelativeDebtor = "ญาติ", GuarBirthDate = Convert.ToDateTime("01-08-1985"), GuarHomePhone = "0860458314" });
            list.Add(new GarantorViewModel { GuarCitizenID = "1111111111117", NameGarantor = "ปทุมวัน อิ่มทรัพย์", RelativeDebtor = "คู่สมรส", GuarBirthDate = Convert.ToDateTime("23-03-1956"), GuarHomePhone = "0857694528" });
            list.Add(new GarantorViewModel { GuarCitizenID = "1111111111116", NameGarantor = "มาโนช พวงพุ่ม", RelativeDebtor = "คู่สมรส", GuarBirthDate = Convert.ToDateTime("14-02-1900"), GuarHomePhone = "038-821007" });
            return list;
        }

        public Boolean Insert(GarantorViewModel obj)
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

        public GarantorViewModel GarantorById(int id)
        {
            var result = new GarantorViewModel
            {
                id = 15,
                GuarCitizenID = "1111111111119",
                GuarTitleName = "01",
                GuarFNameTh = "สมควร",
                GuarLNameTh = "แก้วงาม",
                GuarBirthDate = Convert.ToDateTime("17-04-2000"),
                GuarAgeYear = 23,
                GuarAgeMonth = 3,
                GuarExpiryDate = Convert.ToDateTime("17-04-2019"),
                CitizenStartDate = Convert.ToDateTime("17-04-2001"),
                CitizenPlace = "สถานที่ออกบัตร",
                GuarNationality = "02",
                GuarRace = "03",
                GuarGender = "ชาย",
                RelativeDebtor = "คู่สมรส",
                GuarHomePhone = "038022560",
                GuarMobilePhone = "0122222222",
                GuarResidentOwn = "04",
                GuarResidentOwnDetail = "ระบุ",
                GuarResidentStatus = "05",
                GuarResidentYear = 20,
                GuarResidentMonth = 3,
                GuarResidentRegStatus = "06",
                //อาชีพ
                GuarWorkPeriodAllYear = 21,
                GuarWorkPeriodAllMonth = 5,
                GuarWorkPeriodCurrentYear = 22,
                GuarWorkPeriodCurrentMonth = 6,
                GuarOfficePhone = "022222222",
                GuarOccupationType = "01",
                GuarOccupationGroup = "01",
                GuarOccupationCode = "01",
                GuarPosition = "01",
                OccPlace = "สถานที่ทำงาน",
                OccDetail = "รายละเอียดอาชีพ",
                //รายละเอียดคู่สมรส
                GuarMateName = "บูญมา มากมี",
                GuarMateOccupationGroup = "01",
                GuarMateOccPlace = "สถานทีทำงาน",
                GuarMateIncome = 5000,
                GuarMateOccPosition = "ข้าราชการ",
                GuarMateWorkPeriod = "2",
                GuarMateTelephone = "039204567",
                MateExpense = 20000



                
               


              
               


            };
            return result;
        }
    }
}
