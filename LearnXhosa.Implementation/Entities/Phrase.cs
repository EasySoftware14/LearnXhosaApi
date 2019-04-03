using System.Collections.Generic;

namespace LearnXhosa.Implementation.Entities
{
    public class Phrase : Entity
    {
        public virtual string XhosaPhrase { get; set; }
        public virtual IList<PhraseTranslation> Translation { get; set; }
        public virtual User AddedBy { get; set; }
        public virtual PhraseLevel PhraseLevel{ get; set; }
    }
}
