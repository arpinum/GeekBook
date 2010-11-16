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
            var contact = new Contact()
                              {
                                  Nom = "Dusseaut",
                                  Prénom = "Jb"
                              };

            Assert.That(contact.Nom, Is.EqualTo("Dusseaut"));
            Assert.That(contact.Prénom, Is.EqualTo("Jb"));
        }
    }
}
