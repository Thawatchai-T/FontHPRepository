using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Request;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository.Request
{


    public interface IRequestComHiringRepository
    {
        bool Insert(RequestComHiringDomain entity);
        bool UpdateWithId(RequestComHiringDomain entity);
        bool Delete(RequestComHiringDomain entity);
        List<RequestComHiringDomain> GetAll();
        RequestComHiringDomain GetByID(string requestno, int seq);
    }

    public class RequestComHiringRepository : NhRepository, IRequestComHiringRepository
    {
        public bool Insert(RequestComHiringDomain entity)
        {
            using( var session = SessionFactory.OpenStatelessSession())
            using( var tx = session.BeginTransaction())
            {
                try
                {
                    var obj = session.Insert(entity);
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    Logger.Error(ex);
                    //return
                    throw;
                }
            }
        
        }

        public bool UpdateWithId (RequestComHiringDomain entity)
        {
            try
            {
                this.Update<RequestComHiringDomain>(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(RequestComHiringDomain entity){
            try
            {
                this.Delete<RequestComHiringDomain>(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RequestComHiringDomain> GetAll(){
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<RequestComHiringDomain>().List<RequestComHiringDomain>();
                return result as List<RequestComHiringDomain>;
            }
        }

        public RequestComHiringDomain GetByID(string requestno, int seq)
        {
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<RequestComHiringDomain>().Where((x) => x.RequestNo == requestno)
                                .And(Restrictions.Where<RequestComHiringDomain>((x) => x.SeqNo == seq)).List<RequestComHiringDomain>().FirstOrDefault<RequestComHiringDomain>();
                return result;    
            }
        }
    }
}
