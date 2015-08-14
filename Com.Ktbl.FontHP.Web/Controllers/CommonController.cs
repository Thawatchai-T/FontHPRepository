using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Domain.Common;
using Com.Ktbl.FontHP.Domain.ViewDomain;
using Com.Ktbl.FontHP.Map.Repository;
using Com.Ktbl.FontHP.Web.Models;
using Com.Ktbl.FontHP.Web.Utility;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CommonController : ApiController
    {
        #region properties
        public StandardCodeRepository StandardCodeRepository { get; set; }
        public string Title { get; set; }
        //public List<Province> ComboProvince { get; set; }
        //public static CommonUtility CommonUtility { get; set; }
        #endregion

        // GET api/common
        public IEnumerable<ComboBox> Get(string stdcode)
        {
            try
            {
                var value = Title;
                var result = StandardCodeRepository.GetStandardCodeWithCode(stdcode).Select(
                    x => new ComboBox { id = x.StandardCode, Name = x.StandardName }).ToList<ComboBox>();
                    
                    
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Province District SubDistrict
        /// <summary>
        /// [20150814] Woody 
        /// use for getProvince
        /// </summary>
        /// <returns></returns>
        public List<Province> GetProvince(){

            try
            {
                //var result = CommonUtility.Province;
                return CommonUtility.Province;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// [20150814] Woody 
        /// Use for get district
        /// </summary>
        /// <param name="provinceid"></param>
        /// <returns></returns>
        public List<District> GetDistrict(string provinceid){

            try
            {
                return CommonUtility.District.Where(x => x.ProvinceId == provinceid).ToList<District>();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// [20150814] Woody 
        /// Use for get sub-district
        /// </summary>
        /// <param name="districtid"></param>
        /// <returns></returns>
        public List<SubDistrict> GetSubdistrict(string provinceid,string districtid){

            try
            {
                return CommonUtility.SubDistrict.Where(x => x.DistrinctId == districtid && x.ProvinceId == provinceid).ToList<SubDistrict>();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion


        // GET api/common/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/common
        public void Post([FromBody]string value)
        {
        }

        // PUT api/common/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/common/5
        public void Delete(int id)
        {
        }
    }
}
