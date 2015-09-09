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

                        lmkt.Add(new MarketingModel { id = 1, MarketingName = "สมชาย รักชาย", MarketingCode = "00001", PhoneNo = "0844445344", TypeDealer = "นิติบุคคล", TypeSell="พิเศษ1" });
                        lmkt.Add(new MarketingModel { id = 2, MarketingName = "สมชาย รักหญิง", MarketingCode = "00002", PhoneNo = "0844412344", TypeDealer = "บุคคลธรรมดา", TypeSell = "พิเศษ1" });
                        lmkt.Add(new MarketingModel { id = 3, MarketingName = "สมหญิง รักแฟน", MarketingCode = "00003", PhoneNo = "0844444444", TypeDealer = "นิติบุคคล", TypeSell = "พิเศษ2" });
                        lmkt.Add(new MarketingModel { id = 4, MarketingName = "สมรัก รักเมืองไทย", MarketingCode = "00004", PhoneNo = "0844447894", TypeDealer = "นิติบุคคล", TypeSell = "พิเศษ2" });
                        lmkt.Add(new MarketingModel { id = 5, MarketingName = "สมส่วน รักความสวย", MarketingCode = "00005", PhoneNo = "0844446544", TypeDealer = "บุคคลธรรมดา", TypeSell = "พิเศษ1" });
                        lmkt.Add(new MarketingModel { id = 6, MarketingName = "สมสัก รักสี", MarketingCode = "00006", PhoneNo = "0844455445", TypeDealer = "บุคคลธรรมดา", TypeSell = "พิเศษ1" });

                        lmkt = (string.IsNullOrEmpty(text))?lmkt:lmkt.Where(x=>x.MarketingName.Contains(text)).ToList<MarketingModel>();

                    
            return lmkt;
        }
        #endregion

        #region Bind Data grid 20150827
        public List<GridLead> GetGridLeaderLoad(int start, int limit, int page)
        {
            List<GridLead> list = new List<GridLead>();
            list.Add(new GridLead { Id = 1, ImportId = "0000001", CusName = "วรนุช", CusSurName = "วงสวรรค์", LeadNo = "07-0284", LeadNameGrid = "อชญา", LeadSurNameGrid = "มีทรัพย์", BranchId = "000001", BranchName = "สำนักงานใหญ่" });
            list.Add(new GridLead { Id = 2, ImportId = "0000002", CusName = "พัชราภา", CusSurName = "ไชยเชื้อ", LeadNo = "07-0283", LeadNameGrid = "วาสนา", LeadSurNameGrid = "ริบแจ่ม", BranchId = "000001", BranchName = "สำนักงานใหญ่" });

            
            return list;
        }
        //add searchLead 20150831
        public List<GridLead> GetGridLeaderLoad(int start, int limit, int page, string importid, string leadid, string leadname)
        {
            List<GridLead> lstserch = new List<GridLead>();
            

            lstserch = GetGridLeaderLoad(start, limit, page);
            if (!string.IsNullOrEmpty(importid))
            {
                lstserch = lstserch.Where(l => l.ImportId.Equals(importid)).ToList<GridLead>();;
            }
            if (!string.IsNullOrEmpty(leadid))
            {
                lstserch = lstserch.Where(l => l.LeadNo.Equals(leadid)).ToList<GridLead>();
            }
            if (!string.IsNullOrEmpty(leadname))
            {
                lstserch = lstserch.Where(l => l.LeadNameGrid.Equals(leadname)).ToList<GridLead>();
            }

            return lstserch;
        }
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
            //PK Insert  ครั้งแรก id ยังไม่มีต้องเพิ่มเอง
           
            //list.Add(new GuiPopupCusAddress { AddressType = obj.AddressType, RegistNo=obj.RegistNo, AddressNo=obj.AddressNo,
            //                                  Moo=obj.Moo, MooBaan=obj.MooBaan,Soi=obj.Soi,Street=obj.Street,Province=obj.Province,
            //                                  Amphur=obj.Amphur,Tambon=obj.Tambon,ZipCode=obj.ZipCode,PhoneNo=obj.PhoneNo,
            //                                  FaxNo=obj.FaxNo,StayFromDate=obj.StayFromDate,Mobile=obj.Mobile,PhoneOther=obj.PhoneOther
            //                                });
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
    }
        
}
