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
        bool Insert(EntRelDomain enitity);
        bool Update(EntRelDomain entity);
        bool SaveOrUpdate(EntRelDomain entity);
        List<EntRelDomain> GetAll();
        List<EntRelDomain> GetByID(string comid, string entcode);
    }

    public class EntrelRepository : NhRepository, IEntrelRepository
    {

        public bool Insert(EntRelDomain enitity){
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

        public bool Update(EntRelDomain entity){
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

        public bool SaveOrUpdate(EntRelDomain entity){
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

        public List<EntRelDomain> GetAll(){

            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction()){

                    var result = session.QueryOver<EntRelDomain>().List<EntRelDomain>();
                    return result as List<EntRelDomain>;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        
        }

        public List<EntRelDomain> GetByID(string comid, string entcode)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<EntRelDomain>().Where(Expression.Eq("ComId", comid) && Expression.Eq("EntCode", entcode)).List<EntRelDomain>();

                    return result as List<EntRelDomain>;
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
