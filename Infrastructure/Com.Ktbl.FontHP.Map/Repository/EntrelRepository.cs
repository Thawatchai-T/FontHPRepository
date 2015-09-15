using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using Com.Ktbl.FontHP.Map.Repository;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public interface IEntrelRepository
    {
        bool Insert(EntrelDomain enitity);
        bool Update(EntrelDomain entity);
        bool SaveOrUpdate(EntrelDomain entity);
        List<EntrelDomain> GetAll();
        List<EntrelDomain> GetByID(string comid, string entcode);
    }

    public class EntrelRepository : NhRepository, IEntrelRepository
    {

        public bool Insert(EntrelDomain enitity){
            try
            {
                using(var session = SessionFactory.OpenSession())
                using (var tx = session.BeginTransaction())
                {
                    session.Save(enitity);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public bool Update(EntrelDomain entity){
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    session.Update(entity);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public bool SaveOrUpdate(EntrelDomain entity){
            try
            {
                using(var session = SessionFactory.OpenSession())
                using(var tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public List<EntrelDomain> GetAll(){

            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction()){

                    var result = session.QueryOver<EntrelDomain>().List<EntrelDomain>();
                    return result as List<EntrelDomain>;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        
        }

        public List<EntrelDomain> GetByID(string comid, string entcode)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<EntrelDomain>().Where(Expression.Eq("ComId", comid) && Expression.Eq("EntCode", entcode)).List<EntrelDomain>();

                    return result as List<EntrelDomain>;
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
