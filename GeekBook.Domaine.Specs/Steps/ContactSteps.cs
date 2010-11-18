using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeekBook.EntrepôtsHibernate;
using GeekBook.Modèle;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GeekBook.Domaine.Specs.Steps
{
    [Binding]
    public class ContactSteps
    {
        private Compte _compte;
        public GestionnaireSession GestionnaireSession;


        [BeforeScenario]
        public void Setup()
        {
            GestionnaireSession = new GestionnaireSession();
            Entrepôts.Initialise(new EntrepôtsHbn(GestionnaireSession));
            CurrentSessionContext.Bind(GestionnaireSession.OuvreSession());
            new SchemaExport(GestionnaireSession.Configuration).Execute(false, true, false, GestionnaireSession.SessionCourante.Connection, null);
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
