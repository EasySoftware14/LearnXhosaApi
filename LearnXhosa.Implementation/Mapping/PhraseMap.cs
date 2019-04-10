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

            Map(x => x.XhosaPhrase).Column("phrase");
            Map(x => x.PhraseLevel).Column("level").CustomType<PhraseLevel>();
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
            //HasOne(x => x.AddedBy).LazyLoad().PropertyRef("id").Cascade.All();
            HasMany(x => x.Translation).AsBag().LazyLoad().KeyColumn("phrase_id").Cascade.AllDeleteOrphan();
            HasMany(x => x.Phrases).AsBag().LazyLoad().KeyColumn("added_by").Cascade.AllDeleteOrphan();
        }
    }
}
