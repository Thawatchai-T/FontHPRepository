using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Com.Ktbl.FontHP.Map.Map;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Com.Ktbl.FontHP.Web.Utility
{
    public class NHHelpers
    {
        private string Server { get; set; }
        private int Port { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Database { get; set; }

        public ISessionFactory CreateSessionFactory()
        {
            try
            {
                var sessionf = Fluently.Configure()
                    //.ProxyFactoryFactory<ProxyFactoryFactory>()
                    .Database(MsSqlConfiguration.MsSql2008
                        .ConnectionString(c => c
                            .Server(Server)
                            .Database(Database)
                            .Username(Username)
                            .Password(Password)
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
}