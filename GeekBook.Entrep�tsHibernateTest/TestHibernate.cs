using GeekBook.Entrep�tsHibernate;
using GeekBook.Mod�le;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace GeekBook.Entrep�tsHibernateTest
{
    public class TestHibernate
    {
        protected GestionnaireSession GestionnaireSession;

        [SetUp]
        public void SetupHibernate()
        {
            GestionnaireSession = new GestionnaireSession();
            Entrep�ts.Initialise(new Entrep�tsHbn(GestionnaireSession));
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