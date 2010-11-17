using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GeekBook.Modèle;

namespace GeekBook.EntrepôtsHibernate.Mapping
{
    public sealed class MappingCompte : ClassMap<Compte>
    {
        public MappingCompte()
        {
            Id(c => c.Email);
            Map(c => c.Surnom);
        }
    }
}
