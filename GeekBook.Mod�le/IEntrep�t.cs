using System.Collections.Generic;

namespace GeekBook.Mod�le
{
    public interface IEntrep�t<T>
    {
        void Ajoute(T �l�ment);
        IList<T> Tous();
    }
}