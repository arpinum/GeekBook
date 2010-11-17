using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GeekBook.Modèle
{
    public class Compte
    {
        protected Compte()
        {
            
        }

        public Compte(string email)
        {
            this._email = email;
        }

        public virtual string Email
        {
            get { return _email; }
            private set { _email = value; }
        }

        public virtual string Surnom
        {
            get;
            set;
        }

        public virtual Contact NouveauContact()
        {
            var nouveauContact = new Contact(this);

            return nouveauContact;
        }

        private string _email;
        private string _surnom;

    }
}