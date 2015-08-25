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
using System.Data;
using System.Xml;
using System.Xml.Linq;


namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CommonController : ApiController
    {
        #region properties
        public StandardCodeRepository StandardCodeRepository { get; set; }
       
        //public List<Province> ComboProvince { get; set; }
        //public static CommonUtility CommonUtility { get; set; }
        public IOccupationRepository OccupationRepository { get; set; }
        public IPositionRepository PositionRepository { get; set; }
        public IMainRequestRepository MainRequestRepository { get; set; }
        public ICareerRepository CareerRepository { get; set; }
        //p2p add variable Web Service  20150819
        WebReferenceRedbook.IWS_KTBLBookservice ws = new WebReferenceRedbook.IWS_KTBLBookservice();
        string strXML = "";
        #endregion
    
        // GET api/common
        public IEnumerable<ComboBox> Get(string stdcode)
        {
            try
            {
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
        //p2p Get position


        // GET api/common/5

        #region Occupation section and position [20150817]
        /// <summary>
        /// [20150817]
        /// Get combo-box occupation catelogy
        /// </summary>
        /// <returns>all catelogy</returns>
        public List<ComboBox> GetOccupationCatelogy()
        {
            try
            {
                var result = this.OccupationRepository.GetOccupationCatelogy().Select (x =>new ComboBox{id =x.Id,Name =x.Name }).ToList<ComboBox>();
                
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<ComboBox> GetOccupationGroup()
        {
            try
            {
                var result = this.OccupationRepository.GetOccupationGroup().Select(x => new ComboBox { id = x.Id, Name = x.Name }).ToList<ComboBox>();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// [20150817]
        /// get all occupation group with catelogy id
        /// </summary>
        /// <param name="catid"></param>
        /// <returns>all group</returns>
        public List<ComboBox> GetOccupationGroup(string occupationcatelogyid)
        {
            try
            {
                var result = OccupationRepository.GetOccupationGroup()
                                .Where(x => x.OccupationCatelogy.Id.Equals(occupationcatelogyid))
                                    .Select(x => new ComboBox { id = x.Id, Name = x.Name })
                                    .ToList<ComboBox>();
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// [20150817]
        /// get occupation type with groupid
        /// </summary>
        /// <param name="groupid"></param>
        /// <returns>all type</returns>
        public List<ComboBox> GetOccupationType(string occupationgroupid)
        {
            try
            {
                var result = OccupationRepository.GetOccupationType()
                                .Where(x => x.OccupationGroups.Id.Equals(occupationgroupid))
                                    .Select(x => new ComboBox { id = x.Id, Name = x.Name })
                                    .ToList<ComboBox>();
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        ////p2p 20150818 no load is IsPostBack
        //public List<ComboBox> GetOccupationType()
        //{
        //    try
        //    {
        //        var result = OccupationRepository.GetOccupationType().Select(x => new ComboBox { id = x.Id, Name = x.Name })
        //                            .ToList<ComboBox>();
        //        return result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        /// <summary>
        /// [20150817]
        /// get all position with typeid
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns>all position</returns>
        public List<ComboBox> GetPosition(string occupationcareerid)
        {
            try
            {
                var result = PositionRepository.GetAll()
                                .Where(x => x.OccupationType.Id.Equals(occupationcareerid))
                                    .Select(x => new ComboBox { id = x.Id, Name = x.Name })
                                    .ToList<ComboBox>();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //p2p 20150818 no load is IsPostBack
        //public List<ComboBox> GetPosition()
        //{
        //    try
        //    {
        //        var result = PositionRepository.GetAll()
        //                            .Select(x => new ComboBox { id = x.Id, Name = x.Name })
        //                            .ToList<ComboBox>();
        //        return result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        #endregion 
        //get all career p2p
        // [20150817]

        public List<ComboBox> GetMainCareer()
        {
            try
            {   
                var result = this.CareerRepository.GetMainCareer().Select(x => new ComboBox { id = x.Id, Name = x.Name }).ToList<ComboBox>();
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<ComboBox> GetSubCareerWithMainCareerId(string maincareerid)
        {
            try
            {
                //var result = OccupationRepository.GetOccupationGroup()
                //                .Where(x => x.OccupationCatelogy.Id.Equals(occupationcatelogyid))
                //                    .Select(x => new ComboBox { id = x.Id, Name = x.Name })
                //                    .ToList<ComboBox>();
                //return result;
                var result = CareerRepository.GetSubCareerWithMainCareerId(maincareerid).Select(x => new ComboBox { id = x.Id, Name = x.Name }).ToList<ComboBox>();
                  
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //end
        #region  get data create to combo 20150818
        

       
        
       

       

        public List<ComboBox> GetTypeCar()
        {
            List<ComboBox> list = new List<ComboBox>();
            list.Add(new ComboBox { id = "01", Name = "รถตู้" });
            list.Add(new ComboBox { id = "02", Name = "รถกะบะ" });
            return list;
        }
        #endregion
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

        #region reference redbook webservice
        //p2p 20150819
        //Get WebReferenceRedbook 
        public List<ComboBox> GetBrandCar()
        {
            try
            {
                
                WebReferenceRedbook.TInputBrand objBrand = new WebReferenceRedbook.TInputBrand();
                objBrand.RequestDate = "2015-04-17";
                objBrand.LoanType = "01";
                strXML = ws.GetBrands(objBrand);

                List<ComboBox> list = new List<ComboBox>();
                var doc = XDocument.Parse(strXML);
                list = doc.Descendants("Brand").Select(d => new ComboBox { id = d.Element("BRAND_CODE").Value, Name = d.Element("BRAND_NAME_EN").Value }).ToList<ComboBox>(); 
                return list;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
                        
        }

        public List<ComboBox> GetModelCar(string brandcode)
        //public List<ComboBox> GetModelCar()
        {
            strXML = "";
            WebReferenceRedbook.TInputFamily objFamily = new WebReferenceRedbook.TInputFamily();
            objFamily.RequestDate = "2015-04-17";
            objFamily.LoanType = "01";
            objFamily.BrandCode = brandcode;//T28brandcode
            strXML = ws.GetFamilys(objFamily);

            List<ComboBox> list = new List<ComboBox>();
            var doc = XDocument.Parse(strXML);
            list = doc.Descendants("Family").Select(d => new ComboBox { id = d.Element("FAMILY_CODE").Value, Name = d.Element("FAMILY_NAME_EN").Value }).ToList<ComboBox>(); 
            return list;
           
        }

        public List<ComboBox> GetDetailModelCar(string brandcode, string familycode)
        {
            strXML = "";
            WebReferenceRedbook.TInputDesc objDetailModel = new WebReferenceRedbook.TInputDesc();
            objDetailModel.RequestDate = "2015-04-17";
            objDetailModel.LoanType = "01";
            objDetailModel.BrandCode = brandcode;//T28
            objDetailModel.FamilyCode = familycode;//TOYALP-001
            objDetailModel.CarYear = "";
            //if (objDetailModel.LoanType == "01")
            //{
            //    objDetailModel.CarStatus = (txtCarStatus.Text.Trim().ToString() != "" ? txtCarStatus.Text.Trim().ToString() : "01");
            //}
            //else
            //{
            //    objDetailModel.CarStatus = (txtCarStatus.Text.Trim().ToString() != "" ? txtCarStatus.Text.Trim().ToString() : "02");
            //}
            //objDetailModel.UserLogin = base.CurrentEndUser.UserLogin;
            objDetailModel.CarStatus = "01"; //ต้องดู code ด้านบนตอนเขียนโปรแกรม
            strXML = ws.GetDescriptions(objDetailModel);

            List<ComboBox> list = new List<ComboBox>();
            var doc = XDocument.Parse(strXML);
            list = doc.Descendants("Description").Select(d => new ComboBox { id = d.Element("VEHICLEKEY").Value, Name = d.Element("DESCRIPTION").Value }).ToList();
            return list;
        }
        
        #endregion
    }
}
