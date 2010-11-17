using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GeekBook.Modèle;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace GeekBook.EntrepôtsHibernate
{
    public class EntrepôtsHbn : Entrepôts
    {
        private readonly ISessionFactory _sessionFactory;
        public static ISession sessionCourante;

        public EntrepôtsHbn()
        {
            Configuration configuration = null;
            _sessionFactory = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.InMemory)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EntrepôtsHbn>())
                    .ExposeConfiguration( x => x.SetProperty("current_session_context_class",
                                                             "thread_static"))
                    .ExposeConfiguration(cfg =>  configuration = cfg)
                    .BuildSessionFactory();
            CurrentSessionContext.Bind(_sessionFactory.OpenSession());
            sessionCourante = _sessionFactory.GetCurrentSession();
         new SchemaExport(configuration).Execute(false, true, false, _sessionFactory.GetCurrentSession().Connection, null);
        }

        protected override IEntrepôtCompte EntrepôtCompte()
        {
            return new EntrepôtCompteHibernate(_sessionFactory.GetCurrentSession());
        }

        protected override IEntrepôtContact EntrepôtContact()
        {
            throw new NotImplementedException();
        }
    }
}