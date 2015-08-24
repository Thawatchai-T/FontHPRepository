

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
        List<MainRequestModel> GetMainRequest();
        long GetCountMainRequest();
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
        public List<MainRequestModel> GetMainRequest()
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
                var reslut = session.QueryOver<MainRequest>().List<MainRequest>().Select(x=>new MainRequestModel{
                    Active = x.Active,
                    BranchNo = x.BranchNo,
                    CId = x.CId,
                    DealerName = string.Format("{0} {1} {2}",x.DealerTitle,x.DealerFName,x.DealerLName),
                    DealerPriority = x.DealerPriority,
                    IsGarantor = x.DealerPriority,
                    IsLoan = x.IsLoan,
                    Name = string.Format("{0}{1} {2}",x.TitleName,x.FNameThai,x.LNameThai),
                    Ncb = x.Ncb,
                    RequestDate = x.RequestDate,
                    RequestNo = x.RequestNo,
                    RequestStatusName = x.RequestStatusName,
                    StatusCode = x.StatusCode

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
    }
}
