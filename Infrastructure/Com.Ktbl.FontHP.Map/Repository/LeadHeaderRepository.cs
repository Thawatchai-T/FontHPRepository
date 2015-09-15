using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using NHibernate.Criterion;
using Com.Ktbl.FontHP.Domain;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public class LeadHeaderRepository : NhRepository
    {
        public bool Insert(LeadHeaderDomain enitity)
        {
            try
            {
                var result = this.Insert<LeadHeaderDomain>(enitity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Update(LeadHeaderDomain entity)
        {
            try
            {
                this.Update<LeadHeaderDomain>(entity);
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(LeadHeaderDomain entity)
        {
            try
            {
                this.Delete<LeadHeaderDomain>(entity);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<LeadHeaderDomain> GetAll()
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using (var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<LeadHeaderDomain>().List<LeadHeaderDomain>();
                    return result as List<LeadHeaderDomain>;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }

        }

        public List<LeadHeaderDomain> GetById(string leadno)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<LeadHeaderDomain>().Where(Expression.Eq("LeadNo", leadno)
                            
                        ).List<LeadHeaderDomain>();
                   return result as List<LeadHeaderDomain>;
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
