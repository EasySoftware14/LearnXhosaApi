namespace LearnXhosa.Implementation.Entities
{
    public class PhraseTranslation : Entity
    {
        public virtual User TranslatedBy { get; set; }
        public virtual Phrase PhraseToTranslate { get; set; }
        public virtual string EnglishTranslation { get; set; }

        public PhraseTranslation()
        {}

        public PhraseTranslation(PhraseTranslation translation)
        {
            PhraseToTranslate = translation.PhraseToTranslate;
            EnglishTranslation = translation.EnglishTranslation;
            TranslatedBy = translation.TranslatedBy;
        }

    }
}
