using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeekBook.Modèle
{
    public abstract class Entrepôts
    {
        private static Entrepôts instance;

        public static void Initialise(Entrepôts instance)
        {
            Entrepôts.instance = instance;
        }

        public static IEntrepôtContact Contacts()
        {
            return instance.EntrepôtContact();
        }

        public static IEntrepôtCompte Comptes()
        {
            return instance.EntrepôtCompte();
        }

        protected abstract IEntrepôtCompte EntrepôtCompte();

        protected abstract IEntrepôtContact EntrepôtContact();


    }
}
