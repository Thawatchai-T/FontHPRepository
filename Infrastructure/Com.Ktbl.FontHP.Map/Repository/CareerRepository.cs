using Com.Ktbl.FontHP.Domain.Common;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public interface ICareerRepository
    {
        List<MainCareerDomain> GetMainCareer();
        List<SubCareerDomain> GetSubCareer();
        List<SubCareerDomain> GetSubCareerWithMainCareerId(string maincareer);
    }
    public class CareerRepository : NhRepository,ICareerRepository
    {
        public List<MainCareerDomain> GetMainCareer()
        {
            using(var session =SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<MainCareerDomain>().List<MainCareerDomain>();
                return result as List<MainCareerDomain>;
            }
        }

        public List<SubCareerDomain> GetSubCareer()
        {
            using (var session = SessionFactory.OpenStatelessSession())
            using (var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<SubCareerDomain>().List<SubCareerDomain>();
                return result as List<SubCareerDomain>;
            }

        }

        public List<SubCareerDomain> GetSubCareerWithMainCareerId(string maincareer)
        {
            using (var session = SessionFactory.OpenStatelessSession())
            using (var tx = session.BeginTransaction())
            {
                var result = session.QueryOver<SubCareerDomain>()
                            .Where(Expression.Eq("MainCareerId", maincareer))
                            .List<SubCareerDomain>();
                return result as List<SubCareerDomain>;
            }

        }
    }
}
