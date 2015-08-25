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

        public List<MainRequestModel> GetMainRequest(int start,int limit,int page)
        {
            try
            {
                var startdate = Convert.ToDateTime("2015-05-01");
                
                return MainRequestRepository.GetMainRequest(startdate, DateTime.Now,start, limit);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<MainRequestModel> SearchMainRequest(SearchRequest obj)
        {
            try
            {
                var result = this.MainRequestRepository.SearchMainRequest(obj.Branch,
                    obj.CitizenID, obj.Cusname, obj.Enddate, obj.RequestNo, obj.StartDate,
                    obj.StatusRequest);
                return null;
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
        
    }
}
