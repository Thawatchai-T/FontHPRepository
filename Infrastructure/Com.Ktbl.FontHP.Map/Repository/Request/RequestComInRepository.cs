using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Request;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository.Request
{
    public interface IRequestComInRepository
    {
        bool Insert(RequestComInDomain entity);
        bool UpdateWithId(RequestComInDomain entity);
        bool Delete(RequestComInDomain entity);
        List<RequestComInDomain> GetAll();
        RequestComInDomain GetByID(string requestno, int seq);
    }

    public class RequestComInRepository : NhRepository, IRequestComInRepository
    {
        public bool Insert(RequestComInDomain entity)
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

        public bool UpdateWithId (RequestComInDomain entity)
        {
            try
            {
                this.Update<RequestComInDomain>(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(RequestComInDomain entity){
            try
            {
                this.Delete<RequestComInDomain>(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RequestComInDomain> GetAll(){
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<RequestComInDomain>().List<RequestComInDomain>();
                return result as List<RequestComInDomain>;
            }
        }

        public RequestComInDomain GetByID(string requestno, int seq)
        {
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<RequestComInDomain>().Where((x) => x.RequestNo == requestno)
                                .And(Restrictions.Where<RequestComInDomain>((x) => x.SeqNo == seq)).List<RequestComInDomain>().FirstOrDefault<RequestComInDomain>();
                return result;    
            }
        }
    }
}
