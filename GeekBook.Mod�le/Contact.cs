using System;

namespace GeekBook.Modèle
{
    public class Contact
    {
        protected Contact(){}
        
        public Contact(Compte compte)
        {
            this._compte = compte;
        }

        public virtual int Id { get; private set; }

        public virtual string Prénom { get; set; }

        public virtual string Nom { get; set; }

        public virtual Compte Compte
        {
            get { return this._compte; }
            private set { _compte = value;  }
        }

        private Compte _compte;

        
    }
}