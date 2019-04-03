using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using LearnXhosa.Implementation.Entities;

namespace LearnXhosa.Implementation.Mapping
{
    public class PhraseMap : ClassMap<Phrase>
    {
        public PhraseMap()
        {
            Table("XhosaPhrase");
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.AddedBy).Column("added_by");

            Map(x => x.XhosaPhrase).Column("phrase");
            Map(x => x.PhraseLevel).Column("level").CustomType<PhraseLevel>();
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");

            HasMany(x => x.Translation).AsBag().LazyLoad().KeyColumn("phrase_id").Cascade.AllDeleteOrphan();
        }
    }
}
