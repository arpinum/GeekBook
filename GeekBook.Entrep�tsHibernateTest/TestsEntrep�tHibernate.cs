using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeekBook.Modèle;
using NUnit.Framework;

namespace GeekBook.EntrepôtsHibernateTest
{
    [TestFixture]
    public class TestsEntrepôtHibernate : TestHibernate
    {
        [Test]
        public void PeutAjouter()
        {
            var compte = new Compte("jb.dusseaut@arpinum.com");
            
            Entrepôts.Comptes().Ajoute(compte);

            var comptes = Entrepôts.Comptes().Tous();
            Assert.That(comptes, Is.Not.Null);
            Assert.That(comptes.Count, Is.EqualTo(1));
            Assert.That(comptes[0], Is.EqualTo(compte));
        }
    }
}
