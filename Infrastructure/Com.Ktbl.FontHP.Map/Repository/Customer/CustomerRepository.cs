using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Customer;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository.Request
{
    public interface ICustomerRepository
    {
        bool Insert(CustomerDomain entity);
        bool UpdateWithId(CustomerDomain entity);
        bool Delete(CustomerDomain entity);
        List<CustomerDomain> GetAll();
        CustomerDomain GetByID(string customercode);
    }

    public class CustomerRepository : NhRepository, ICustomerRepository
    {
        public bool Insert(CustomerDomain entity)
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

        public bool UpdateWithId (CustomerDomain entity)
        {
            try
            {
                this.Update<CustomerDomain>(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(CustomerDomain entity){
            try
            {
                this.Delete<CustomerDomain>(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CustomerDomain> GetAll(){
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<CustomerDomain>().List<CustomerDomain>();
                return result as List<CustomerDomain>;
            }
        }

        public CustomerDomain GetByID(string customercode)
        {
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<CustomerDomain>().Where((x) => x.CustomerCode == customercode).List<CustomerDomain>().FirstOrDefault<CustomerDomain>();
                return result;    
            }
        }
    }
}
