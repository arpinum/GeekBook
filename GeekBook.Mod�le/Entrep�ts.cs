using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeekBook.Modèle
{
    public abstract class Entrepôts
    {
        private static Entrepôts _instance;

        public static void Initialise(Entrepôts instance)
        {
            Entrepôts._instance = instance;
        }

        public static IEntrepôtContact Contacts()
        {
            return _instance.EntrepôtContact();
        }

        public static IEntrepôtCompte Comptes()
        {
            return _instance.EntrepôtCompte();
        }

        protected abstract IEntrepôtCompte EntrepôtCompte();

        protected abstract IEntrepôtContact EntrepôtContact();


    }
}
