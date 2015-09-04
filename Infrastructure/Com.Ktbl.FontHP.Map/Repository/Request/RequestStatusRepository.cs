using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common.Reqeust;

namespace Com.Ktbl.FontHP.Map.Repository.Request
{
    public interface IRequestStatusRepository
    {
        int TotalRowCount { get; set; }
        List<RequestStatusDomain> GetRequestStatusByRequestNo(string requestno);
    }
    public class RequestStatusRepository : NhRepository, IRequestStatusRepository
    {
        public int TotalRowCount { get; set; }

        public List<RequestStatusDomain> GetRequestStatusByRequestNo(string requestno)
        {

            try
            {
                using(var session = SessionFactory.OpenSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<RequestStatusDomain>().Where(x => x.RequestNo.Equals(requestno));
                    this.TotalRowCount = result.RowCount();
                    return result.List<RequestStatusDomain>() as List<RequestStatusDomain>;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }

        public List<RequestStatusDomain> GetRequestStatus(string requestno)
        {

            try
            {
                using (var session = SessionFactory.OpenSession())
                using (var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<RequestStatusDomain>()
                        //.WhereRestrictionOn()
                        .Where(x => x.RequestNo.Equals(requestno));
                    this.TotalRowCount = result.RowCount();
                    return result.List<RequestStatusDomain>() as List<RequestStatusDomain>;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }
    }
}
