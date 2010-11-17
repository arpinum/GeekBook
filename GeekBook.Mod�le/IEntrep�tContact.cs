using System.Collections.Generic;

namespace GeekBook.Modèle
{
    public interface IEntrepôtContact : IEntrepôt<Contact>
    {
        IList<Contact> ParCompte(Compte compte);
    }
}