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
                //var result = session.QueryOver<StandardCodes>().Where(Expression.Eq("StandardType", code)).List<StandardCodes>();
                var result = session.QueryOver<StandardCodes>().Where(Expression.Eq("StandardType", code)
                            && Expression.Eq("Active", true)
                            ).List<StandardCodes>();
                return result as List<StandardCodes>;

            }

        }

        public bool Insert(StandardCodes enitity)
        {
            try
            {
                var result = this.Insert<StandardCodes>(enitity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Update(StandardCodes entity)
        {
            try
            {
                this.Update<StandardCodes>(entity);
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(StandardCodes entity)
        {
            try
            {
                this.Delete<StandardCodes>(entity);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<StandardCodes> GetAll()
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using (var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<StandardCodes>();
                    return result as List<StandardCodes>;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw;
            }

        }

        public List<StandardCodes> GetById(string stdtype, string stdcode)
        {
            try
            {
                using(var session = SessionFactory.OpenStatelessSession())
                using(var tx = session.BeginTransaction())
                {
                    var result = session.QueryOver<StandardCodes>().Where(Expression.Eq("StandardType", stdtype)
                            && Expression.Eq("StandardCode", stdcode)
                        ).List<StandardCodes>();
                   return result as List<StandardCodes>;
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
