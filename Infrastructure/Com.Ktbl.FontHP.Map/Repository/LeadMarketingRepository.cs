using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public interface ILeadMarketingRepository
    {
        List<LeadMktDomain> GetAllMarketing();

        //add Interfacr GetById p2p 20150917
        List<LeadMktDomain> GetById(string marketingname);
    }
    public class LeadMarketingRepository : NhRepository, ILeadMarketingRepository
    {
        public List<LeadMktDomain> GetAllMarketing()
        {
            using (var session = SessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var ct = session.CreateCriteria<LeadMktDomain>();
                ct.Add(Restrictions.Eq("IsActive", true));
                ct.Add(Restrictions.Eq("EmpGroup", "09"));
                //var result = ct.SetProjection(Projections.ProjectionList()
                //    .Add(Projections.Property("EmpId"))
                //    .Add(Projections.Property("EmpCode"))
                //    .Add(Projections.Property("MktName"))
                //    ).List();
                var result = ct.List<LeadMktDomain>();
                return result.ToList<LeadMktDomain>() as List<LeadMktDomain> ;
               
            }

        }
        //Add GetById and Like MarketingName p2p 20150917
        public List<LeadMktDomain> GetById(string marketname)
        {
            try
            {
                using (var session = SessionFactory.OpenStatelessSession())
                using (var tx = session.BeginTransaction())
                {
                    
                   
                    var result = session.QueryOver <LeadMktDomain>().Where(Restrictions.On<LeadMktDomain>(c=>c.MktName).IsLike ("%"+marketname+"%")).List<LeadMktDomain>();
                    return result as List<LeadMktDomain>;
                        
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
