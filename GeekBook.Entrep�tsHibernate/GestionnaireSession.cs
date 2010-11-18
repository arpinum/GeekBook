using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace GeekBook.EntrepôtsHibernate
{
    public class GestionnaireSession
    {
        private readonly ISessionFactory _sessionFactory;
        private Configuration _configuration;

        public GestionnaireSession()
        {
            _sessionFactory = Fluently.Configure()
                .Database(ConfigurationBase())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EntrepôtsHbn>())
                .ExposeConfiguration(cfg => _configuration = cfg)
                .ExposeConfiguration(cfg => cfg.SetProperty("current_session_context_class", "thread_static"))
                .BuildSessionFactory();
        }

        protected virtual SQLiteConfiguration ConfigurationBase()
        {
            return new SQLiteConfiguration().InMemory();
        }

        public Configuration Configuration
        {
            get { return _configuration; }
        }

        public ISession OuvreSession()
        {
            return _sessionFactory.OpenSession();
        }

        public ISession SessionCourante
        {
            get { return _sessionFactory.GetCurrentSession(); }
        }
    }
}