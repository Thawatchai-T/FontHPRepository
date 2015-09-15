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
    public interface IFamilyRepository
    {
        bool Insert(FamilyDomain enitity);
        bool Update(FamilyDomain entity);
        bool SaveOrUpdate(FamilyDomain entity);
        List<FamilyDomain> GetAll();
        List<FamilyDomain> GetByID(string brandcode, string familycode);
    }

    public class FamilyRepository : NhRepository, IFamilyRepository
    {

        public bool Insert(FamilyDomain enitity){
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

        public bool Update(FamilyDomain entity){
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

        public bool SaveOrUpdate(FamilyDomain entity){
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

        public List<FamilyDomain> GetAll(){

            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction()){

                    var result = session.QueryOver<FamilyDomain>().List<FamilyDomain>();
                    return result as List<FamilyDomain>;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        
        }

        public List<FamilyDomain> GetByID(string brandcode, string familycode)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<FamilyDomain>().Where(Expression.Eq("BrandCode", brandcode) && Expression.Eq("FamilyCode", familycode)).List<FamilyDomain>();

                    return result as List<FamilyDomain>;
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
