using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GeekBook.Modèle.Tests
{
    [TestFixture]
    public class TestsContact
    {
        [Test]
        public void PeutCréer()
        {
            var contact = new Contact(new Compte("jb@arpinum.com"))
                              {
                                  Nom = "Dusseaut",
                                  Prénom = "Jb"
                              };

            Assert.That(contact.Nom, Is.EqualTo("Dusseaut"));
            Assert.That(contact.Prénom, Is.EqualTo("Jb"));
        }

        [Test]
        public void NePeutPasCréerDeContactSansCpmpte()
        {
            var compte = new Compte("jb@arpinum.com");
           
            var contact = compte.NouveauContact();
            
            Assert.That(contact, Is.Not.Null);
            Assert.That(contact.Compte, Is.EqualTo(compte));
        }
    }
}
