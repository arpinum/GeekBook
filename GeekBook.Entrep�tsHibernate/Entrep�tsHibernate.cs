using System;
using GeekBook.Modèle;

namespace GeekBook.EntrepôtsHibernate
{
    public class EntrepôtsHibernate : Entrepôts
    {
        protected override IEntrepôtCompte EntrepôtCompte()
        {
            throw new NotImplementedException();
        }

        protected override IEntrepôtContact EntrepôtContact()
        {
            throw new NotImplementedException();
        }
    }
}