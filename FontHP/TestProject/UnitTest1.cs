using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Com.Ktbl.FontHP.Map.Map;
using Com.Ktbl.FontHP.Map.Repository;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        #region TestRunThirdPartyMarketing
        [TestMethod]
        public void TestGetById()
        {
            try
            {
                ThirdPartyMarketingRepository target = new ThirdPartyMarketingRepository();
                target.SessionFactory = this.CreateSessionFactory();
                string dealercode = "SU00153500";
                string marketcode = "91088";
                var actual = target.GetById(dealercode, marketcode);
                Assert.AreEqual(1, actual.Count);
                //Assert.Equals(Expected,result)
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void TestGetAll()
        {
            try
            {
                ThirdPartyMarketingRepository target = new ThirdPartyMarketingRepository();
                target.SessionFactory = this.CreateSessionFactory();
                var actual = target.GetAll();
                Assert.AreEqual(true, (actual.Count>0));
              
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void TestJoinWithMapping()
        {
            LeadHeaderRepository target = new LeadHeaderRepository();
            target.SessionFactory = this.CreateSessionFactory();

            var result = target.JoinWithOutMap();

            Assert.AreEqual(true, result.Count > 0);

        }


        #region Test LeadHeaderRepository
        [TestMethod]
        public void TestGetLeadHeaderById()
        {
            LeadHeaderRepository target = new LeadHeaderRepository();
            target.SessionFactory = this.CreateSessionFactory();
            string leadno = "0800001";

            var actual = target.GetById(leadno);
            Assert.AreEqual(1, actual.Count);
        }

        [TestMethod]
        public void TestGetLeadHeaderAll()
        {
            LeadHeaderRepository target = new LeadHeaderRepository();
            target.SessionFactory = this.CreateSessionFactory();
            var actual = target.GetAll();
            Assert.AreEqual(true, (actual.Count > 0));
        }
        #endregion
        [TestMethod]
        //public void TestBindGrid()
        //{
        //    LeadHeaderRepository target = new LeadHeaderRepository();
        //    target.SessionFactory = this.CreateSessionFactory();
        //    var actual = target.GetLeadHeader();
        //    Assert.AreEqual(true, (actual.Count > 0));
        //}
        private ISessionFactory CreateSessionFactory()
        {
            try
            {
                var sessionf = Fluently.Configure()
                    //.ProxyFactoryFactory<ProxyFactoryFactory>()
                    .Database(MsSqlConfiguration.MsSql2008
                        .ConnectionString(c => c
                            .Server("221.23.4.64")
                            .Database("KTBLeasing")
                            .Username("sa")
                            .Password("ktblitadmin")
                        )
                    )
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StandardCodeMap>())
                    .ExposeConfiguration(c => c.SetProperty("current_session_context_class", "thread_static"))
                    .BuildSessionFactory();
                return sessionf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); //ex.Message;
                //  return null;
            }
            
        }
    }
        #endregion
}
