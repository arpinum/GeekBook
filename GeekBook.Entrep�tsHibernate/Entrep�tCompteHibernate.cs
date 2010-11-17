using System;
using System.Collections.Generic;
using GeekBook.Modèle;
using NHibernate;

namespace GeekBook.EntrepôtsHibernate
{
    public class EntrepôtCompteHibernate : IEntrepôtCompte
    {
        private readonly ISession _session;

        public EntrepôtCompteHibernate(ISession session)
        {
            _session = session;
        }

        public void Ajoute(Compte élément)
        {
            _session.Save(élément);
            _session.Flush();
        }

        public IList<Compte> Tous()
        {
            return _session.CreateCriteria<Compte>().List<Compte>();
        }
    }
}