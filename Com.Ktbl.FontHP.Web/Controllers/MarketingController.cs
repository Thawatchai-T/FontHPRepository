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
using Com.Ktbl.FontHP.Domain;



namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class MarketingController : ApiController
    {
        public IMainRequestRepository  MainRequestRepository {get;set;}
      
        public IOccupationRepository OccupationRepository { get; set; }
        public ILeadMarketingRepository LeadMarketingRepository { get; set; }
        public LeadHeaderRepository LeadHeaderRepository { get; set; }
        public ThirdPartyMarketingRepository ThirdPartyMarketingRepository { get; set; }
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
                List<MarketingModel> lmkt = new List<MarketingModel>();
                
                var result = LeadMarketingRepository.GetAllMarketing();
                pagemd.total = result.Count();
               
                lmkt = result.Select(x => new MarketingModel { 
                    id = x.EmpId,
                    MarketingCode = x.MktCode,
                    MarketingName = string.Format("{0} ({1})",x.MktName,x.MktNickName),
                    PhoneNo = x.TelNumber
                }).Skip(start).Take(limit).ToList<MarketingModel>();

                pagemd.items = lmkt;
               
                return pagemd  ;
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
                var result = LeadMarketingRepository.GetById(text);
                pagemd.total = result.Count();

                lmkt = result.Select(x => new MarketingModel
                {
                    id = x.EmpId,
                    MarketingCode = x.MktCode,
                    MarketingName = string.Format("{0} ({1})", x.MktName, x.MktNickName),
                    PhoneNo = x.TelNumber
                }).Skip(start).Take(limit).ToList<MarketingModel>();

                pagemd.items = lmkt;

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
            //Model 201509
                        //lmkt.Add(new MarketingModel { id = "1", MarketingName = "สมชาย รักชาย", MarketingCode = "00001", PhoneNo = "0844445344", TypeDealer = "นิติบุคคล", TypeSell="พิเศษ1" });
                        //lmkt.Add(new MarketingModel { id = 2, MarketingName = "สมชาย รักหญิง", MarketingCode = "00002", PhoneNo = "0844412344", TypeDealer = "บุคคลธรรมดา", TypeSell = "พิเศษ1" });
                        //lmkt.Add(new MarketingModel { id = 3, MarketingName = "สมหญิง รักแฟน", MarketingCode = "00003", PhoneNo = "0844444444", TypeDealer = "นิติบุคคล", TypeSell = "พิเศษ2" });
                        //lmkt.Add(new MarketingModel { id = 4, MarketingName = "สมรัก รักเมืองไทย", MarketingCode = "00004", PhoneNo = "0844447894", TypeDealer = "นิติบุคคล", TypeSell = "พิเศษ2" });
                        //lmkt.Add(new MarketingModel { id = 5, MarketingName = "สมส่วน รักความสวย", MarketingCode = "00005", PhoneNo = "0844446544", TypeDealer = "บุคคลธรรมดา", TypeSell = "พิเศษ1" });
                        //lmkt.Add(new MarketingModel { id = 6, MarketingName = "สมสัก รักสี", MarketingCode = "00006", PhoneNo = "0844455445", TypeDealer = "บุคคลธรรมดา", TypeSell = "พิเศษ1" });

                        //lmkt = (string.IsNullOrEmpty(text))?lmkt:lmkt.Where(x=>x.MarketingName.Contains(text)).ToList<MarketingModel>();

                    
            return null;
        }
        #endregion

        #region Bind Data grid 20150827
        #region insert PageModel 20150917
        public PageModel<GridLead> GetGridLeaderLoad(int start, int limit, int page)
        {
            try
            {
                PageModel<GridLead> pagemd = LeaderProcess(start, limit);
                return pagemd;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// [20150918] Add by Woody.
        /// Method search form popup 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <param name="QImportId"></param>
        /// <param name="QLeadId"></param>
        /// <param name="QLeadName"></param>
        /// <returns>result search</returns>
        /// &importid=&leadid=&leadname=วิรัตน์&page=1&start=0&limit=20
        public PageModel<GridLead> GetGridLeaderLoad(int start, int limit, string leadname, string leadid, string importid)
        {
            try
            {
                PageModel<GridLead> pagemd = LeaderProcess(start, limit, importid, leadid, leadname);
                return pagemd;
            }
            catch (Exception)
            {

                throw;
            }

        }


        /// <summary>
        ///  [20150918] Add by Woody. 
        ///  Method core search Leader popup.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <returns>pagemode</returns>
        private PageModel<GridLead> LeaderProcess(int start, int limit, string importid = null, string leadid = null, string leadname = null)
        {
            PageModel<GridLead> pagemd = new PageModel<GridLead>();
            List<GridLead> list = new List<GridLead>();
            var LeadHeader = LeadHeaderRepository.GetAll();
            var LeadMkt = LeadMarketingRepository.GetAllMarketing();
            var guery = (from lh in LeadHeader
                         join lm in LeadMkt on lh.MarketingCode equals lm.MktCode
                         select new GridLead { ImportId = lh.LeadNo, CusName = lh.CustomerName, CusSurName = lh.CustomerSurName, LeadNo = lm.MktCode, LeadNameGrid = lm.MktName, LeadSurNameGrid = lm.MktName, BranchId = lh.BranchCode, BranchName = lh.BranchName }).ToList<GridLead>();
            //if (!string.IsNullOrEmpty(importid) || !string.IsNullOrEmpty(leadid) || !string.IsNullOrEmpty(leadname))
            //{
            //    if (!string.IsNullOrEmpty(importid))
            //        guery = guery.Where(x => x.ImportId == importid);
            //    if(!string.IsNullOrEmpty(leadid))
            //        guery = guery.Where(x => x.LeadNo == leadid);
            //    if(!string.IsNullOrEmpty(leadname))
            //        guery = guery.Where(x => x.LeadNameGrid.Contains(leadname));
                
            //}
          //  IQueryable<GridLead> query = guery;
            pagemd.items = guery.Skip(start).Take(limit).ToList<GridLead>();
            pagemd.total = guery.ToList<GridLead>().Count;
            return pagemd;
        }
        #endregion
        public List<GridLead> GetGridLeaderLoad()
        {
            List<GridLead> list = new List<GridLead>();
            list.Add(new GridLead { Id = 1, ImportId = "0000001", CusName = "วรนุช", CusSurName = "วงสวรรค์", LeadNo = "07-0284", LeadNameGrid = "อชญา", LeadSurNameGrid = "มีทรัพย์", BranchId = "000001", BranchName = "สำนักงานใหญ่" });
            list.Add(new GridLead { Id = 2, ImportId = "0000002", CusName = "พัชราภา", CusSurName = "ไชยเชื้อ", LeadNo = "07-0283", LeadNameGrid = "วาสนา", LeadSurNameGrid = "ริบแจ่ม", BranchId = "000001", BranchName = "สำนักงานใหญ่" });

            
            return null;
        }
        //add searchLead 20150831
        //public PageModel <GridLead> GetGridLeaderLoad(int start, int limit, int page, string importid, string leadid, string leadname)
        //{
        //    PageModel<GridLead> pagemd = new PageModel<GridLead>();
        //    List<GridLead> lstserch = new List<GridLead>();
        //    lstserch = GetGridLeaderLoad(); 
        //    if (!string.IsNullOrEmpty(importid))
        //    {
        //        lstserch = lstserch.Where(l => l.ImportId.Equals(importid)).ToList<GridLead>();;
        //    }
        //    if (!string.IsNullOrEmpty(leadid))
        //    {
        //        lstserch = lstserch.Where(l => l.LeadNo.Equals(leadid)).ToList<GridLead>();
        //    }
        //    if (!string.IsNullOrEmpty(leadname))
        //    {
        //        lstserch = lstserch.Where(l => l.LeadNameGrid.Equals(leadname)).ToList<GridLead>();
        //    }

        //    pagemd.items = lstserch.Skip(start).Take(limit).ToList<GridLead>();
        //    pagemd.total = lstserch.Count;
        //    return pagemd;
        //}
        #endregion

        #region add manange PopupDealer 20150901
        public List<GridDealer> GetGridDealerLoad(int start, int limit, int page)
        {
            List<GridDealer> list = new List<GridDealer>();
            list.Add(new GridDealer { DealerCode = "001",DealerName = "ใบตอง" });
            list.Add(new GridDealer { DealerCode = "002", DealerName = "ใบเตย" });
            list.Add(new GridDealer { DealerCode = "003", DealerName = "ใบแก้ว" });
            list.Add(new GridDealer { DealerCode = "004", DealerName = "ใบกล้วย" });
            return list;
          
        }

        //add searchDealer 20150901
        public List<GridDealer> GetGridDealerLoad(int start, int limit, int page, string dealercode, string dealername)
        {
            List<GridDealer> lstserch = new List<GridDealer>();


            lstserch = GetGridDealerLoad(start, limit, page);
            if (!string.IsNullOrEmpty(dealercode))
            {
                lstserch = lstserch.Where(l => l.DealerCode.Equals(dealercode)).ToList<GridDealer>(); ;
            }
            if (!string.IsNullOrEmpty(dealername))
            {
                lstserch = lstserch.Where(l => l.DealerName.Equals(dealername)).ToList<GridDealer>();
            }
            return lstserch;
        }

       #endregion

        #region add ManagePopupCusAddress
        public List<GridPopCusAddress> GetGridPopCusAddress(int start, int limit, int page)
        {
            List<GridPopCusAddress> list = new List<GridPopCusAddress>();
            list.Add(new GridPopCusAddress { id = 1, AddressType = "ประเภทที่อยู่1", Address = "ปิ่นเกล้า", PhoneNo = "037200001", FaxNo = "Fax001", StayFromDate = Convert.ToDateTime("10-05-2009") });
            list.Add(new GridPopCusAddress { id = 2, AddressType = "ประเภทที่อยู่2", Address = "บางนา", PhoneNo = "038300001", FaxNo = "Fax002", StayFromDate = Convert.ToDateTime("07-10-2008") });
            list.Add(new GridPopCusAddress { id = 3, AddressType = "ประเภทที่อยู่3", Address = "ปบางกะปิ", PhoneNo = "039400001", FaxNo = "Fax003", StayFromDate = Convert.ToDateTime("12-09-2007") });
            list.Add(new GridPopCusAddress { id = 4, AddressType = "ประเภทที่อยู่4", Address = "เจ้าพระยา", PhoneNo = "028500001", FaxNo = "Fax004", StayFromDate = Convert.ToDateTime("13-07-2006") });
            list.Add(new GridPopCusAddress { id = 5, AddressType = "ประเภทที่อยู่5", Address = "วงเวียนใหญ่", PhoneNo = "037600001", FaxNo = "Fax005", StayFromDate = Convert.ToDateTime("01-04-2005") });
            
            return list ;
        }
        #endregion
        #region add PopupCusAddress 20150902 p2p
        public Boolean AddPopCusAddress(GuiPopupCusAddress obj)
        {
            List<GridPopCusAddress>  listGrid = new List<GridPopCusAddress>();
            List<GuiPopupCusAddress> list = new List<GuiPopupCusAddress>();
            if (obj.id != null)
            {
                //Pk Update 
            }
            else
            {
            
            }
            return true;
        }
        /// <summary>
        /// insert or upate
        /// </summary>
        /// <param name="value"></param>
        public bool Post(GuiPopupCusAddress obj)
        {
            if (obj.id == 0)
            {
                //TODO:  Insert
            }
            else
            {
                //TODO:  Update
            }
            return true;
        }

        // DELETE api/common/5
        public void Delete(int id)
        {
            //TODO:  not implement
        }
        #endregion
//
        public GuiPopupCusAddress GetAddressById(int id)
        {
            var result = new GuiPopupCusAddress
            {
               id = 15,
               CutomerType = "ผู้คำประกัน",
               AddressNo = "11123",
               AddressType = "ประเภทที่อยู่1",
               Amphur ="02",
               FaxNo ="020000000",
               Mobile = "0841111111",
               Moo = "5",
               MooBaan = "big",
               PhoneNo ="0841111111",
               PhoneOther ="-",
               Province = "10",
               RegistNo ="0123456",
               Soi ="14",
               StayFromDate = Convert.ToDateTime("01-04-2005"),
               Street ="เมื่อง",
               Tambon ="04",
               ZipCode ="57140"
            };
            return result;
        }

        #region Cancel Flag
        public bool GetCancelMarketingById(string id,string remark)
        {
            try
            {
                string str = id;
            }
            catch (Exception ex )
            {

                throw ex; 
            }
                    


            return true;
        }
        #endregion


    }
        
}
