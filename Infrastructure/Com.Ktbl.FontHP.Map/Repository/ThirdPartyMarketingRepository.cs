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
    public class ThirdPartyMarketingRepository: NhRepository
    {
        public bool Insert(ThirdPartyMarketingDomain enitity)
        {
            try
            {
                var result = this.Insert<ThirdPartyMarketingDomain>(enitity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Update(ThirdPartyMarketingDomain entity)
        {
            try
            {
                this.Update<ThirdPartyMarketingDomain>(entity);
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(ThirdPartyMarketingDomain entity)
        {
            try
            {
                this.Delete<ThirdPartyMarketingDomain>(entity);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<ThirdPartyMarketingDomain> GetAll()
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using (var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<ThirdPartyMarketingDomain>().List<ThirdPartyMarketingDomain>();
                    return result as List<ThirdPartyMarketingDomain>;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }

        }

        public List<ThirdPartyMarketingDomain> GetById(string dealercode, string marketcode)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<ThirdPartyMarketingDomain>().Where(Expression.Eq("DealerCode", dealercode)
                            && Expression.Eq("MarketingCode", marketcode)
                        ).List<ThirdPartyMarketingDomain>();
                   return result as List<ThirdPartyMarketingDomain>;
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
