using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeekBook.Modèle;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GeekBook.Domaine.Specs.Steps
{
    [Binding]
    public class ContactSteps
    {
        private Compte _compte;

        [BeforeScenario]
        public void Setup()
        {
            Entrepôts.Initialise(new EntrepôtsHibernate.EntrepôtsHbn());
        }

        [Given(@"je suis ""(.*)""")]
        public void GivenJeSuis(string surnom)
        {
            _compte = new Compte("");
            Entrepôts.Comptes().Ajoute(_compte);
        }
        [When(@"je crée (\d*) contact[s]?")]
        public void WhenJeCréeUnContact(int nombre)
        {
            for (int i = 0; i < nombre; i++)
            {
                Contact nouveauContact = _compte.NouveauContact();
                Entrepôts.Contacts().Ajoute(nouveauContact);
            }
        }
        [Then(@"j'ai (\d*) contact[s]?")]
        public void ThenJaiNContact(int nombre)
        {
            Assert.That(Entrepôts.Contacts().ParCompte(_compte).Count, Is.EqualTo(nombre));
        }

    }
}
