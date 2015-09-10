using Com.Ktbl.FontHP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Com.Ktbl.FontHP.Web.Controllers
{
    public class CheckDocumentController : ApiController
    {
        #region manage CheckPaper 20150910
        public List<CheckDocumentViewModel> GetCheckDocumentLoad(int start, int limit, int page)
        {
            List<CheckDocumentViewModel> list = new List<CheckDocumentViewModel>();
            var pagemodel = new PageModel<CheckDocumentViewModel>();

            list.Add(new CheckDocumentViewModel { id = 1, RequestNo = "58000001", RequestDate = Convert.ToDateTime("07-04-2014"), IdApprove = "01", CitizenId = "1111111111119", CusName = "มาลา มาลัย", TypeLoan = "ประเภทสินเชื่อ 1", BranchName = "สำนักงานใหญ่", National = "ไทย" });
            list.Add(new CheckDocumentViewModel { id = 2, RequestNo = "58000002", RequestDate = Convert.ToDateTime("17-05-2015"), IdApprove = "02", CitizenId = "1111111111117", CusName = "มะลิ บานบิ่ง", TypeLoan = "ประเภทสินเชื่อ 2", BranchName = "ลำปาง", National = "ลาว" });
            list.Add(new CheckDocumentViewModel { id = 3, RequestNo = "58000007", RequestDate = Convert.ToDateTime("05-06-2015"), IdApprove = "01", CitizenId = "1111111111116", CusName = "มะยม บานแล้ว", TypeLoan = "ประเภทสินเชื่อ 3", BranchName = "สำนักงานใหญ่", National = "พม่า" });
            list.Add(new CheckDocumentViewModel { id = 4, RequestNo = "58000008", RequestDate = Convert.ToDateTime("27-07-2015"), IdApprove = "02", CitizenId = "1111111111115", CusName = "มะกูด อิ่มต้น", TypeLoan = "ประเภทสินเชื่อ 4", BranchName = "ลำปาง", National = "ไทย" });
            return list;
        }

        public List<CheckDocumentViewModel> GetCheckDocumentLoad(int start, int limit, int page, string startdate, string enddate, string cusname, string statusRequest, string requestno, string citizenid, string branch)
        {
            List<CheckDocumentViewModel> lstserch = new List<CheckDocumentViewModel>();


            lstserch = GetCheckDocumentLoad(start,limit,page);
            if (!string.IsNullOrEmpty(requestno))
            {
                lstserch = lstserch.Where(l => l.RequestNo.Equals(requestno)).ToList<CheckDocumentViewModel>(); ;
            }

            return lstserch;
        }
        public Boolean Insert(CheckDocumentViewModel obj)
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

        #endregion
        

        #region manage historyPaper 20150910
        public List<HistoryDocumentViewModel> GetHistoryDocumentLoad(int start, int limit, int page)
        {
            List<HistoryDocumentViewModel> list = new List<HistoryDocumentViewModel>();


            list.Add(new HistoryDocumentViewModel { id = 1, RequestNo = "58000001", RequestDate = Convert.ToDateTime("07-04-2014"), RequestStatus = "01", CitizenId = "1111111111119", CusName = "มาลา มาลัย", NCBStatus = "ผ่าน" });
            list.Add(new HistoryDocumentViewModel { id = 2, RequestNo = "58000002", RequestDate = Convert.ToDateTime("17-05-2015"), RequestStatus = "02", CitizenId = "1111111111117", CusName = "มะลิ บานบิ่ง", NCBStatus = "ไม่ผ่าน"});
            list.Add(new HistoryDocumentViewModel { id = 3, RequestNo = "58000007", RequestDate = Convert.ToDateTime("05-06-2015"), RequestStatus = "01", CitizenId = "1111111111116", CusName = "มะยม บานแล้ว", NCBStatus = "ผ่าน"});
            list.Add(new HistoryDocumentViewModel { id = 4, RequestNo = "58000008", RequestDate = Convert.ToDateTime("27-07-2015"), RequestStatus = "02", CitizenId = "1111111111115", CusName = "มะกูด อิ่มต้น", NCBStatus = "ไม่ผ่าน" });
            return list;
        }

        public List<HistoryDocumentViewModel> GetHistoryDocumentLoad(int start, int limit, int page, string startdate, string enddate, string cusname, string statusRequest, string requestno, string citizenid, string branch)
        {
            List<HistoryDocumentViewModel> lstserch = new List<HistoryDocumentViewModel>();


            lstserch = GetHistoryDocumentLoad(start,limit,page);
            if (!string.IsNullOrEmpty(requestno))
            {
                lstserch = lstserch.Where(l => l.RequestNo.Equals(requestno)).ToList<HistoryDocumentViewModel>(); ;
            }

            return lstserch;
        }

        #endregion
       
        // GET api/checkdocument/5
       

        // POST api/checkdocument
        public void Post([FromBody]string value)
        {
        }

        // PUT api/checkdocument/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/checkdocument/5
        public void Delete(int id)
        {
        }
    }
}
