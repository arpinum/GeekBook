using System;

namespace GeekBook.Modèle
{
    public class Contact
    {
        public Contact(Compte compte)
        {
            this._compte = compte;
        }

        public string Prénom { get; set; }
        
        public string Nom { get; set; }
       
        public Compte Compte
        {
            get { return this._compte; }
        }

        private Compte _compte;
    }
}