using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Com.Ktbl.FontHP.Domain.Common;
using Com.Ktbl.FontHP.Domain.ViewDomain;
using Com.Ktbl.FontHP.Domain.ViewsModel;
using Com.Ktbl.FontHP.Web.Models;
using Com.Ktbl.FontHP.Web.Utility;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using Com.Ktbl.FontHP.Map.Repository;
using System.Globalization;


namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class MarketingController : ApiController
    {
        public IMainRequestRepository  MainRequestRepository {get;set;}
        public IOccupationRepository OccupationRepository { get; set; }
         
      // public void Test(DateTime  StartDate,DateTime  Enddate,string RequestNo,string StatusRequest,string CitizenID,string Cusname,string Branch)
        public void Test (SearchRequest obj)
        {
          
        }
        //fit startdate enedate 20150825 DateTime.Now
        public List<MainRequestModel> GetMainRequest(int start,int limit,int page)
        {
            try
            {
               
               // DateTime startdate = DateTime.ParseExact("20150701", "yyyyMMdd", CultureInfo.InvariantCulture);
                var startdate = Convert.ToDateTime("2015-07-01");
                return MainRequestRepository.GetMainRequest(startdate, DateTime.Now, start, limit);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        //public List<MainRequestModel> GetMainRequest(int start, int limit, int page, List<MainRequestModel> obj)
        //{
        //    try
        //    {
        //         return obj;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //p2p 20150825 set format date
        public List<MainRequestModel> SearchMainRequest(SearchRequest obj)
        {
            try
            {
                //DateTime startdate = DateTime.ParseExact("20150701", "yyyyMMdd", CultureInfo.InvariantCulture);
                //DateTime Enddate = DateTime.ParseExact("20150706", "yyyyMMdd", CultureInfo.InvariantCulture);
                
                var result = this.MainRequestRepository.SearchMainRequest(obj.Branch,
                    obj.CitizenID, obj.Cusname, obj.Enddate, obj.RequestNo, obj.StartDate,
                    obj.StatusRequest);
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        //public List<SearchRequest> GetGridRequestNO()
        //{
        //    try
        //    {
               
        //        var result = this.
        //        return result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        #region Bind Data grid 20150827
        public List<LeadSearch> GetGridLeaderLoad()
        {
            List<LeadSearch> list = new List<LeadSearch>();
            list.Add(new LeadSearch { Id = 1, ImportId = "0000001", CusName = "วรนุช", CusSurName = "วงสวรรค์", LeadNo = "07-0284", LeadNameGrid = "อชญา", LeadSurNameGrid = "มีทรัพย์", BranchId = "000001", BranchName = "สำนักงานใหญ่" });
            list.Add(new LeadSearch { Id = 2, ImportId = "0000002", CusName = "วรนุช", CusSurName = "วงสวรรค์", LeadNo = "07-0284", LeadNameGrid = "อชญา", LeadSurNameGrid = "มีทรัพย์", BranchId = "000001", BranchName = "สำนักงานใหญ่" });

            
            return list;
        }

        #endregion

    }
}
