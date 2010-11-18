using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GeekBook.Modèle;

namespace GeekBook.EntrepôtsHibernate.Mapping
{
    public sealed class MappingContact : ClassMap<Contact>
    {
        public MappingContact()
        {
            Id(c => c.Id);
            Map(c => c.Nom);
            Map(c => c.Prénom);
            References(c => c.Compte).Cascade.None();
        }
    }
}
