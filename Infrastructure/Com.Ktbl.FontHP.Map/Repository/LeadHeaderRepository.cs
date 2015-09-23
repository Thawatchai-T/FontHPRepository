using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using NHibernate.Criterion;
using Com.Ktbl.FontHP.Domain;
using Com.Ktbl.FontHP.Domain.ViewsModel;



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

        #region bind grid 20150915
        //public List<MainLeadModel> GetLeadHeader()
        //{
        //    using (var session = SessionFactory.OpenStatelessSession())
        //    using (var tx = session.BeginTransaction())
        //    {

        //        var Province = session.QueryOver<ProvinceDomain>().List<ProvinceDomain>();
        //        var LeadHeader = session.QueryOver<LeadHeaderDomain>().List<LeadHeaderDomain>();

        //        var result = (from a in LeadHeader
        //                      join b in Province on a.CustomerProvinceId equals b.ProvinceId
        //                     select new MainLeadModel { BranchId = a.BranchCode, BranchName = a.BranchName, CusSurName = b.ProvinceName }).ToList<MainLeadModel>();
        //        /*
        //         into joined
        //         from j in joined.DefaultIfEmpty()
        //        select new 
        //        {
        //            a.LeadNo,
        //            j.ProvinceName
        //        };
        //         * */
        //        var sb = result.Count();
        //        return null;// result.ToList<MainLeadModel>();
        //    }
        //}
        #endregion



        public List<object[]> JoinWithOutMap()
        {
            try
            {

                using (var session = SessionFactory.OpenStatelessSession())
                using (var tx = session.BeginTransaction())
                { 
                    LeadHeaderDomain obj1 =null;
                    LeadMktDomain obj2 = null;
                    var query = QueryOver.Of<LeadMktDomain>(()=>obj2)
                        .Select(Projections.ProjectionList()
                                           .Add(Projections.Property<LeadMktDomain>(x => x.MktCode))
                                           //.Add(Projections.Property<LeadMktDomain>(x => x.MktName))
                                )
                                .Where(Restrictions.EqProperty("obj2.MktCode", "obj1.MarketingCode") && Restrictions.IsNotNull("obj2.MktName"));

                    var result = session.QueryOver<LeadHeaderDomain>(() => obj1)
                                .Select(Projections.ProjectionList()
                                        .Add(Projections.Property<LeadHeaderDomain>(x => x.MarketingCode))
                                        .Add(Projections.Property<LeadHeaderDomain>(x => x.AdviserName))
                                        .Add(Projections.SubQuery(query)))
                                .List<object[]>();

                    return result as List<object[]>;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
