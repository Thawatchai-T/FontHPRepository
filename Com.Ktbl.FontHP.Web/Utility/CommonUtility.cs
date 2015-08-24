using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Com.Ktbl.FontHP.Domain.ViewDomain;
using Com.Ktbl.FontHP.Map.Repository;

namespace Com.Ktbl.FontHP.Web.Utility
{
    public class CommonUtility
    {
        public static List<Province> Province { get; set; }
        public static List<District> District { get; set; }
        public static List<SubDistrict> SubDistrict { get; set; }

        

        

        public CommonUtility(IProvinceRepository province){
           
            Province = province.ProvinceAll();
            District = province.DistrictAll();
            SubDistrict = province.SubDistrictAll();
        }

        public static IProvinceRepository ProvinceRepository { get; set; }

        public static List<Province> GetProvince(){

            try
            {
                var province = CommonUtility.Province;
                return province;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        public static List<District> GetDistrict(string provinceid)
        {
            try
            {
                return District;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        public static List<SubDistrict> GetSubDistrict()
        {
            try
            {
                return SubDistrict;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}