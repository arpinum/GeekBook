using GeekBook.EntrepôtsHibernate;
using GeekBook.Modèle;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace GeekBook.EntrepôtsHibernateTest
{
    public class TestHibernate
    {
        protected GestionnaireSession GestionnaireSession;

        [SetUp]
        public void SetupHibernate()
        {
            GestionnaireSession = new GestionnaireSession();
            Entrepôts.Initialise(new EntrepôtsHbn(GestionnaireSession));
            CurrentSessionContext.Bind(GestionnaireSession.OuvreSession());
            new SchemaExport(GestionnaireSession.Configuration).Execute(false, true, false, GestionnaireSession.SessionCourante.Connection, null);
        }

        [TearDown]
        public void TeardDownHibernate()
        {
            GestionnaireSession.SessionCourante.Close();
        }
    }
}