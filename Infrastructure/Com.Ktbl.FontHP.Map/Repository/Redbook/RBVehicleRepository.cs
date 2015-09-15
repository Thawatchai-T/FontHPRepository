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
    public interface IRBVehicleRepository
    {
        bool Insert(RBVehicleDomain enitity);
        bool Update(RBVehicleDomain entity);
        bool SaveOrUpdate(RBVehicleDomain entity);
        List<RBVehicleDomain> GetAll();
        List<RBVehicleDomain> GetByID(string effectivedate, string vehiclekey);
    }

    public class RBVehicleRepository : NhRepository, IRBVehicleRepository
    {

        public bool Insert(RBVehicleDomain enitity){
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

        public bool Update(RBVehicleDomain entity){
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

        public bool SaveOrUpdate(RBVehicleDomain entity){
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

        public List<RBVehicleDomain> GetAll(){

            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction()){

                    var result = session.QueryOver<RBVehicleDomain>().List<RBVehicleDomain>();
                    return result as List<RBVehicleDomain>;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        
        }

        public List<RBVehicleDomain> GetByID(string effectivedate, string vehiclekey)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<RBVehicleDomain>().Where(Expression.Eq("EffectiveDate", effectivedate) && Expression.Eq("VehicleKey", vehiclekey)).List<RBVehicleDomain>();

                    return result as List<RBVehicleDomain>;
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
