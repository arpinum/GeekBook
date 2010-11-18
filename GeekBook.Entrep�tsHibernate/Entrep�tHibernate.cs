using System.Collections.Generic;
using GeekBook.Mod�le;
using NHibernate;

namespace GeekBook.Entrep�tsHibernate
{
    public abstract class Entrep�tHibernate<T> : IEntrep�t<T>
    {
        protected readonly ISession Session;

        protected Entrep�tHibernate(ISession sessionCourante)
        {
            Session = sessionCourante;
        }

        public void Ajoute(T �l�ment)
        {
            Session.Save(�l�ment);
            Session.Flush();
        }

        public IList<T> Tous()
        {
            return Session.CreateCriteria(typeof (T)).List<T>();
        }
    }
}