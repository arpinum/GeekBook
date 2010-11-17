using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GeekBook.Modèle
{
    public class Compte
    {
        public Compte(string email)
        {
            this._email = email;
        }

        public string Email
        {
            get { return _email; }
        }

        public string Surnom
        {
            get;
            set;
        }

        public Contact NouveauContact()
        {
            var nouveauContact = new Contact(this);

            return nouveauContact;
        }

        private readonly string _email;
        private string _surnom;

    }
}