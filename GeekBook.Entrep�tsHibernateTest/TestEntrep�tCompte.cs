using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Testing;
using GeekBook.EntrepôtsHibernate;
using GeekBook.Modèle;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace GeekBook.EntrepôtsHibernateTest
{
    [TestFixture]
    public class TestEntrepôtCompte : TestHibernate
    {
        [Test]
        public void EstBienMappé()
        {
            new PersistenceSpecification<Compte>(GestionnaireSession.SessionCourante)
                .CheckProperty(c => c.Surnom, "BodySplash")
                .CheckProperty(c => c.Email, "jb.dusseaut@arpinum.com").VerifyTheMappings();
        }
    }
}
