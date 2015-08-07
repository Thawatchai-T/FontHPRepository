using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using NHibernate.Criterion;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public class StandardCodeRepository: NhRepository
    {
        public List<StandardCodes> GetStandardCodeWithCode(string code){
            
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction()){
                var result = session.QueryOver<StandardCodes>().Where(Expression.Eq("StandardType", code)).List<StandardCodes>();
                return result as List<StandardCodes>;
            }

        }
    }
}
