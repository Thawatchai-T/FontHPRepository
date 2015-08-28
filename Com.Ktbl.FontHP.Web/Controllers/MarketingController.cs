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

        /// <summary>
        /// [20150827] Add by Woody 
        /// user for main marketing page
        /// </summary>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="StartDate"></param>
        /// <param name="Enddate"></param>
        /// <param name="RequestNo"></param>
        /// <param name="StatusRequest"></param>
        /// <param name="CitizenID"></param>
        /// <param name="Branch"></param>
        /// <returns></returns>
        public List<MainRequestModel> GetMainRequest(int start, int limit, int page, string StartDate, string Enddate,
                string RequestNo, string StatusRequest, string CitizenID, string Branch)
        {
            try
            {
                var param = new SearchRequest{
                    StartDate = StartDate,
                    Branch = Branch,
                    CitizenID = CitizenID,
                    Cusname = CitizenID,
                    Enddate = Enddate,
                    RequestNo =  RequestNo,
                    StatusRequest = StatusRequest
                };
                var result = this.SearchMainRequest(param).Skip(start).Take(limit).ToList <MainRequestModel>();
                
                return result as List<MainRequestModel>;
            }
            catch (Exception)
            {

                throw;
            }
        }

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

        #region [20150828] Add by Woody for serch markiting popup
        public PageModel<MarketingModel> GetMarketing(int start, int limit, int page)
        {
            try
            {
                PageModel<MarketingModel> pagemd = new PageModel<MarketingModel>();
                List<MarketingModel> lmkt =  new List<MarketingModel>();
                lmkt = ManageMarketing(lmkt, null);
                pagemd.items = lmkt.Skip(start).Take(limit).ToList<MarketingModel>();
                return pagemd;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public PageModel<MarketingModel> GetMarketing(int start, int limit, int page, string text)
        {
            try
            {
                PageModel<MarketingModel> pagemd = new PageModel<MarketingModel>();
                List<MarketingModel> lmkt = new List<MarketingModel>();
                lmkt = ManageMarketing(lmkt, text);
                pagemd.items = lmkt.Skip(start).Take(limit).ToList<MarketingModel>();
                pagemd.total = lmkt.Count;
                return pagemd;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private List<MarketingModel> ManageMarketing(List<MarketingModel> lmkt, string text)
        {
            //TODO:  Donot implement search by name

                        lmkt.Add(new MarketingModel{id= 1, MarketingName = "สมชาย รักชาย", MarketingCode ="00001", PhoneNo="0844445344" });
                        lmkt.Add(new MarketingModel{id= 2, MarketingName = "สมชาย รักหญิง", MarketingCode ="00002", PhoneNo="0844412344" });
                        lmkt.Add(new MarketingModel{id= 3, MarketingName = "สมหญิง รักแฟน", MarketingCode ="00003", PhoneNo="0844444444" });
                        lmkt.Add(new MarketingModel{id= 4, MarketingName = "สมรัก รักเมืองไทย", MarketingCode ="00004", PhoneNo="0844447894" });
                        lmkt.Add(new MarketingModel{id= 5, MarketingName = "สมส่วน รักความสวย", MarketingCode ="00004", PhoneNo="0844446544" });
                        lmkt.Add(new MarketingModel{id= 6, MarketingName = "สมสัก รักสี", MarketingCode ="00004", PhoneNo="0844455444" });

                        lmkt = (string.IsNullOrEmpty(text))?lmkt:lmkt.Where(x=>x.MarketingName.Contains(text)).ToList<MarketingModel>();

                    
            return lmkt;
        }
        #endregion

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
