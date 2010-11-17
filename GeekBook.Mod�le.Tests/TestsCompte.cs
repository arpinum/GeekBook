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
        public void PeutDéfinirSurnom()
        {
            _compte.Surnom = "JB";

            Assert.That(_compte.Surnom, Is.EqualTo("JB"));

        }
    }
}
