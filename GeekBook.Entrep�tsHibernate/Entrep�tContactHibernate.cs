using System;
using System.Collections.Generic;
using System.Linq;
using GeekBook.Modèle;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace GeekBook.EntrepôtsHibernate
{
    public class EntrepôtContactHibernate : EntrepôtHibernate<Contact>, IEntrepôtContact
    {
        public EntrepôtContactHibernate(ISession sessionCourante)
            : base(sessionCourante)
        {
        }

        public IList<Contact> ParCompte(Compte compte)
        {
            var comptes = from item in Session.Linq<Contact>() select item;
            return comptes.Where(c => c.Compte.Equals(compte)).ToList<Contact>();
        }
    }
}