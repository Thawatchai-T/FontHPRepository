

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.ViewDomain;
using Com.Ktbl.FontHP.Domain.ViewsModel;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public interface IMainRequestRepository
    {
        List<MainRequestModel> GetMainRequest(DateTime startdate, DateTime enddate, int start, int limit);
        long GetCountMainRequest();

        List<MainRequestModel> SearchMainRequest(string Branch, string CitizenID, string Cusname, string Enddate, string RequestNo,string StartDate, string StatusRequest);
    }

    /// <summary>
    /// Craeate by Woody [20150824]
    /// </summary>
    public class MainRequestRepository : NhRepository, IMainRequestRepository
    {
        /// <summary>
        /// Grid view main marketing 
        /// </summary>
        /// <returns>list of view model grid </returns>
        public List<MainRequestModel> GetMainRequest(DateTime startdate, DateTime enddate,int start, int limit)
        {
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                //var ct = session.CreateCriteria<MainRequest>();
                //ct.SetProjection(Projections.ProjectionList()
                //    .Add(Projections.Property(""))
                //    .Add(Projections.Property(""))
                //    .Add(Projections.Property(""))
                //    .Add(Projections.Property(""))
                //    .Add(Projections.Property(""))
                //    .Add(Projections.Property(""))
                //    .Add(Projections.Property(""))
                //    );
                
                //TODO: main requestgrid 

                var reslut = session.QueryOver<MainRequest>()
                    .And(Expression.Between("RequestDate",startdate,enddate)).Skip(start).Take(limit)
                    //.And(Expression.Between("RequestDate","20150701","20150706")).Skip(start).Take(limit)
                    .List<MainRequest>().Select(x=>new MainRequestModel{
                    Active = x.Active,
                    BranchNo = x.BranchNo,
                    CitizenId = x.CId,
                    DealerName = string.Format("{0} {1} {2}",x.DealerTitle,x.DealerFName,x.DealerLName),
                    DealerPriority = x.DealerPriority,
                    IsGarantor = x.DealerPriority,
                    Loan = x.IsLoan,
                    CusName = string.Format("{0}{1} {2}",x.TitleName,x.FNameThai,x.LNameThai),
                    Ncb = x.Ncb,
                    RequestDate = x.RequestDate,
                    RequestNo = x.RequestNo,
                    RequestStatus = x.RequestStatusName,
                    StatusCode = x.StatusCode,
                    NCBStatus = "ยังหาค่าไม่ได้"

                }).ToList < MainRequestModel>();

                return reslut as List<MainRequestModel>;
            }
        }
        
        public long GetCountMainRequest(){

            using(var session = SessionFactory.OpenSession())
            using(var tx = session.BeginTransaction())
            {
                var count = session.QueryOver<MainRequest>().RowCountInt64();
                return count;
            }
            
        }

        public List<MainRequestModel> SearchMainRequest(string Branch, string CitizenID, string Cusname, string Enddate, string RequestNo, string StartDate, string StatusRequest)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {


                    DateTime DStartDate = Convert.ToDateTime(StartDate);
                    DateTime DEnddate = Convert.ToDateTime(Enddate);

                   //Enddate = Convert.ToDateTime("2015-07-01");
                    var crt = session.CreateCriteria<MainRequest>();
                    crt.Add(Expression.Between("RequestDate", DStartDate, DEnddate));

                    if(!string.IsNullOrEmpty(RequestNo))
                        crt.Add(Expression.Eq("RequestNo", RequestNo));

                    if(!string.IsNullOrEmpty(CitizenID))
                        crt.Add(Expression.Eq("CId", CitizenID));

                    if(!string.IsNullOrEmpty(Cusname))
                        crt.Add(Expression.Like("FNameThai", Cusname, MatchMode.Anywhere) || Expression.Like("LNameThai", Cusname, MatchMode.Anywhere));
                    
                    if(!string.IsNullOrEmpty(Branch))
                        crt.Add(Expression.Eq("BranchNo", Branch));
                    
                    if(!string.IsNullOrEmpty(StatusRequest))
                        crt.Add(Expression.Eq("StatusCode", StatusRequest));

                    var result = crt.List<MainRequest>().Skip(0).Take(25).Select(x=>new MainRequestModel{
                    Active = x.Active,
                    BranchNo = x.BranchNo,
                    CitizenId = x.CId,
                    DealerName = string.Format("{0} {1} {2}",x.DealerTitle,x.DealerFName,x.DealerLName),
                    DealerPriority = x.DealerPriority,
                    IsGarantor = x.DealerPriority,
                    Loan = x.IsLoan,
                    CusName = string.Format("{0}{1} {2}",x.TitleName,x.FNameThai,x.LNameThai),
                    Ncb = x.Ncb,
                    RequestDate = x.RequestDate,
                    RequestNo = x.RequestNo,
                    RequestStatus = x.RequestStatusName,
                    StatusCode = x.StatusCode,
                    NCBStatus = "ยังหาค่าไม่ได้"

                }).ToList <MainRequestModel>();
                    return result as List<MainRequestModel>;
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
