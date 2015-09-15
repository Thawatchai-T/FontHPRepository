using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using Com.Ktbl.FontHP.Map.Repository;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository.Redbook
{
    public interface IBrandRepository
    {
        bool Insert(BrandDomain enitity);
        bool Update(BrandDomain entity);
        bool SaveOrUpdate(BrandDomain entity);
        List<BrandDomain> GetAll();
        List<BrandDomain> GetByID(string brandcode);
    }

    public class BrandRepository : NhRepository, IBrandRepository
    {

        public bool Insert(BrandDomain enitity){
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

        public bool Update(BrandDomain entity){
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

        public bool SaveOrUpdate(BrandDomain entity){
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

        public List<BrandDomain> GetAll(){

            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction()){

                    var result = session.QueryOver<BrandDomain>().List<BrandDomain>();
                    return result as List<BrandDomain>;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        
        }

        public List<BrandDomain> GetByID(string brandcode)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<BrandDomain>().Where(Expression.Eq("BrandCode", brandcode)).List<BrandDomain>();

                    return result as List<BrandDomain>;
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
