using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GeekBook.Modèle
{
    public class Compte
    {
        private readonly string _email;
        private IList<Contact> _contacts = new List<Contact>();

        public Compte(string email)
        {
            this._email = email;
        }

        public string Email
        {
            get { return _email; }
        }

        public IList<Contact> Contacts {
            get { return new ReadOnlyCollection<Contact>(_contacts); }
        }

        public void AjouterContact(Contact contact)
        {
            _contacts.Add(contact);
        }
    }
}