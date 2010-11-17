using System.Collections.Generic;

namespace GeekBook.Modèle
{
    public interface IEntrepôt<T>
    {
        void Ajoute(T élément);
        IList<T> Tous();
    }
}