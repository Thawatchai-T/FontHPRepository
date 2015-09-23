using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Request;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository.Request
{
    public interface IRequestPaydealerRepository
    {
        bool Insert(RequestPaydealerDomain entity);
        bool UpdateWithId(RequestPaydealerDomain entity);
        bool Delete(RequestPaydealerDomain entity);
        List<RequestPaydealerDomain> GetAll();
        RequestPaydealerDomain GetByID(string requestno, int seq);
    }

    public class RequestPaydealerRepository : NhRepository, IRequestPaydealerRepository
    {
        public bool Insert(RequestPaydealerDomain entity)
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

        public bool UpdateWithId (RequestPaydealerDomain entity)
        {
            try
            {
                this.Update<RequestPaydealerDomain>(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(RequestPaydealerDomain entity){
            try
            {
                this.Delete<RequestPaydealerDomain>(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RequestPaydealerDomain> GetAll(){
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<RequestPaydealerDomain>().List<RequestPaydealerDomain>();
                return result as List<RequestPaydealerDomain>;
            }
        }

        public RequestPaydealerDomain GetByID(string requestno, int seq)
        {
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<RequestPaydealerDomain>().Where((x) => x.RequestNo == requestno).List<RequestPaydealerDomain>().FirstOrDefault<RequestPaydealerDomain>();
                return result;    
            }
        }
    }
}
