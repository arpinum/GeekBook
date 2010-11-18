using System;
using System.Collections.Generic;
using GeekBook.Modèle;
using NHibernate;

namespace GeekBook.EntrepôtsHibernate
{
    public class EntrepôtCompteHibernate : EntrepôtHibernate<Compte>, IEntrepôtCompte
    {

        public EntrepôtCompteHibernate(ISession session) : base(session)
        {
        }

    }
}