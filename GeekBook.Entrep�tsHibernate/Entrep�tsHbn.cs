using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GeekBook.Modèle;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace GeekBook.EntrepôtsHibernate
{
    public class EntrepôtsHbn : Entrepôts
    {
        private readonly GestionnaireSession _gestionnaireSession;

        public EntrepôtsHbn(GestionnaireSession gestionnaireSession)
        {
            _gestionnaireSession = gestionnaireSession;
        }

        protected override IEntrepôtCompte EntrepôtCompte()
        {
            return new EntrepôtCompteHibernate(_gestionnaireSession.SessionCourante);
        }

        protected override IEntrepôtContact EntrepôtContact()
        {
            return new EntrepôtContactHibernate(_gestionnaireSession.SessionCourante);
        }
    }
}