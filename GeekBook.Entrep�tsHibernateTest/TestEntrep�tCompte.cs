using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeekBook.EntrepôtsHibernate;
using GeekBook.Modèle;
using NHibernate.Context;
using NUnit.Framework;

namespace GeekBook.EntrepôtsHibernateTest
{
    [TestFixture]
    public class TestEntrepôtCompte
    {
        [Test]
        public void PeutAjouter()
        {
            Entrepôts.Initialise(new EntrepôtsHbn());
            var compte = new Compte("jb.dusseaut@arpinum.com");
            compte.Surnom = "BodySplash";

            Entrepôts.Comptes().Ajoute(compte);
            EntrepôtsHbn.sessionCourante.Clear();

            var comptes = Entrepôts.Comptes().Tous();
            Assert.That(comptes.Count, Is.EqualTo(1));
            Assert.That(comptes[0].Email, Is.EqualTo("jb.dusseaut@arpinum.com"));
            Assert.That(comptes[0].Surnom, Is.EqualTo("BodySplash"));
        }
    }
}
