using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GeekBook.Modèle.Tests
{
    [TestFixture]
    public class TestsCompte
    {
        private Compte _compte;

        [SetUp]
        public void SetUp()
        {
            _compte = new Compte("jb.dusseaut@arpinum.fr");
        }
        
        [Test]
        public void PeutCreerCompte()
        {
            Assert.That(_compte.Email, Is.EqualTo("jb.dusseaut@arpinum.fr"));
        }

        [Test]
        public void PeutAjouterContact()
        {
            var contact = new Contact() {Nom = "Hanna", Prénom = "Samir"};
         
            _compte.AjouterContact(contact);
            
            Assert.That(_compte.Contacts.Count, Is.EqualTo(1));

            var contactTrouvé = _compte.Contacts[0];
            
            Assert.That(contactTrouvé, Is.EqualTo(contact));
        }

    }
}
