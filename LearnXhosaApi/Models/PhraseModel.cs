using Entity = LearnXhosa.Implementation.Entities;

namespace LearnXhosaApi.Models
{
    public class PhraseModel
    {
        public long Id { get; set; }
        public string XhosaPhrase { get; set; }
        public Entity.PhraseTranslation Translation { get; set; }
        public Entity.User User { get; set; }
        public int PhraseLevel { get; set; }    
    }
}