using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using LearnXhosa.Implementation.Entities;

namespace LearnXhosa.Implementation.Mapping
{
    public class PhraseTranslationMap : ClassMap<PhraseTranslation>
    {
        public PhraseTranslationMap()
        {
            Table("PhraseTranslation");
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.PhraseToTranslate).Column("phrase_id");
            Map(x => x.EnglishTranslation).Column("translation");
            References(x => x.TranslatedBy).Column("translated_by");
            Map(x => x.CreatedAt).Column("created_at");
            Map(x => x.ModifiedAt).Column("modified_at");
        }
    }
}
