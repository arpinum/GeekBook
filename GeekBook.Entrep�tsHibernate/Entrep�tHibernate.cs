using System.Collections.Generic;
using GeekBook.Modèle;
using NHibernate;

namespace GeekBook.EntrepôtsHibernate
{
    public abstract class EntrepôtHibernate<T> : IEntrepôt<T>
    {
        protected readonly ISession Session;

        protected EntrepôtHibernate(ISession sessionCourante)
        {
            Session = sessionCourante;
        }

        public void Ajoute(T élément)
        {
            Session.Save(élément);
            Session.Flush();
        }

        public IList<T> Tous()
        {
            return Session.CreateCriteria(typeof (T)).List<T>();
        }
    }
}