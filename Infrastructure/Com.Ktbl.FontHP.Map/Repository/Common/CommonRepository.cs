using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using Com.Ktbl.FontHP.Domain.ViewsModel;
using NHibernate.Criterion;


namespace Com.Ktbl.FontHP.Map.Repository.Common
{
    public interface ICommonRepository
    {
        List<LeadHeaderDomain> GetLeadManagement(string leadno, string advisercode, string advisername, int start, int limit);
        void GetBrand(string brand);
        PageModel<EntRelDomain> GetEntRel(int start, int limit, string entcode, string namet);
    }
    public class CommonRepository : NhRepository, ICommonRepository
    {
        public List<LeadHeaderDomain> GetLeadManagement(string leadno,string advisercode,string advisername,int start,int limit){
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var cri = session.CreateCriteria<LeadHeaderDomain>();
                    
                    if(!string.IsNullOrEmpty(leadno)) cri.Add(Expression.Eq("LeadNo",leadno) );
                    
                    if(!string.IsNullOrEmpty(advisercode)) cri.Add(Expression.Eq("AdviserCode",advisercode));
                    
                    if(!string.IsNullOrEmpty(advisername)) cri.Add(Expression.Like("AdviserName",advisername,MatchMode.Anywhere));
                    
                    var result = cri.List<LeadHeaderDomain>();

                    return result as List<LeadHeaderDomain>;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }
        }

        public void GetBrand(string brand){
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var crt = session.QueryOver<BrandDomain>().Where(x=>x.Active == true);
                    var result = crt.List<BrandDomain>(); 
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public PageModel<EntRelDomain> GetEntRel(int start, int limit, string entcode, string namet)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    PageModel<EntRelDomain> entity = new PageModel<EntRelDomain>();
                    
                    //var crt = session.CreateCriteria<EntRelDomain>();

                    //if (!string.IsNullOrEmpty(entcode)) crt.Add(Expression.Eq("EntCode", entcode));

                    //if(!string.IsNullOrEmpty(namet)) crt.Add(Expression.Like("EntNameTH",namet,MatchMode.Anywhere));

                    var query = session.QueryOver<EntRelDomain>();
                    if (!string.IsNullOrEmpty(entcode)) 
                        query.Where(x => x.EntCode == entcode);

                    if (!string.IsNullOrEmpty(namet))
                        query.Where(x => x.NameTH.IsLike(namet, MatchMode.Anywhere));
                                        
                    var result = query.Skip(start).Take(limit).Future<EntRelDomain>();
                    var rowcount = session.QueryOver<EntRelDomain>()
                        .Select(Projections.Count(Projections.Id()))
                        .FutureValue<int>().Value;

                    entity.items = result as List<EntRelDomain>;
                    entity.total = rowcount;
                    return entity;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

    }
}
