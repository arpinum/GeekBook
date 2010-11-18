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


        public override bool Equals(object obj)
        {
            if (obj != null && obj is Compte)
            {
                var autre = (Compte) obj;
                return autre.Email == Email;
            }
            return false;
        }

        public static bool operator == (Compte compte, Compte autre)
        {
            if(compte != null)
            {
                return compte.Equals(autre);
            }

            return false;
        }

        public static bool operator !=(Compte compte, Compte autre)
        {
            return !(compte == autre);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private string _email;
        private string _surnom;
    }
}