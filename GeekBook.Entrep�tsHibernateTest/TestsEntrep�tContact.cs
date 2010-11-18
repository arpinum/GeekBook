using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Testing;
using GeekBook.Modèle;
using NUnit.Framework;

namespace GeekBook.EntrepôtsHibernateTest
{
    [TestFixture]
    public class TestsEntrepôtContact : TestHibernate
    {
        [Test]
        public void EstBienMappé()
        {
            new PersistenceSpecification<Contact>(GestionnaireSession.SessionCourante)
                .CheckProperty(c => c.Nom, "Dusseaut")
                .CheckProperty(c => c.Prénom, "Jean-baptiste")
                .CheckReference(c => c.Compte, new Compte("plop"))
                .VerifyTheMappings();
        }

        [Test]
        public void PeutRécupérerParCompte()
        {
            var compteJb = new Compte("plip");
            var compteSam = new Compte("plop");
            var nouveauContact = compteJb.NouveauContact();
            Entrepôts.Contacts().Ajoute(nouveauContact);
            Entrepôts.Comptes().Ajoute(compteJb);
            Entrepôts.Comptes().Ajoute(compteSam);

            var contactsJb = Entrepôts.Contacts().ParCompte(compteJb);
            var contactsSam = Entrepôts.Contacts().ParCompte(compteSam);

            Assert.That(contactsJb.Count, Is.EqualTo(1));
            Assert.That(contactsSam.Count, Is.EqualTo(0));
        }
    }
}
