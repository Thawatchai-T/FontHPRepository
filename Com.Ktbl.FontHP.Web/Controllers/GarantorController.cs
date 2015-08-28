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
        public List<GridGarantor> GetGridGarantorLoad() 
        {
            List<GridGarantor> list = new List<GridGarantor>();
          
            list.Add(new GridGarantor { CiticenId = "1111111111119", NameGarantor = "จารุวรรณ มากมี", CusRelationShip = "คู่สมรส", BirthDate =  Convert.ToDateTime("17-04-2000"), Tel="035-023887" });
            list.Add(new GridGarantor { CiticenId = "1111111111118", NameGarantor = "มารุต ปานทุ่ม", CusRelationShip = "ญาติ", BirthDate = Convert.ToDateTime("01-08-1985"), Tel = "0860458314" });
            list.Add(new GridGarantor { CiticenId = "1111111111117", NameGarantor = "ปทุมวัน อิ่มทรัพย์", CusRelationShip = "คู่สมรส", BirthDate = Convert.ToDateTime("23-03-1956"), Tel = "0857694528" });
            list.Add(new GridGarantor { CiticenId = "1111111111116", NameGarantor = "มาโนช พวงพุ่ม", CusRelationShip = "คู่สมรส", BirthDate =  Convert.ToDateTime("14-02-1900"), Tel = "038-821007" });
            return list;
        }
    }
}
