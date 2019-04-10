using System.Collections.Generic;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using LearnXhosa.Repository.PhraseRepository;
using LearnXhosa.Services.Contracts;

namespace LearnXhosa.Services.Services
{
    public class EnglishPhraseService : IEnglishPhraseService
    {
        private readonly IEnglishPhraseRepository _englishPhraseRepository;

        public EnglishPhraseService()
        {
            _englishPhraseRepository = new EnglishPhrasesRepository();
        }
        public long Save(PhraseTranslation entity)
        {
            return _englishPhraseRepository.AddEntity(entity);
        }

        public void Update(PhraseTranslation entity)
        {
            _englishPhraseRepository.Update(entity);
        }

        public void Delete(PhraseTranslation entity)
        {
            _englishPhraseRepository.Delete(entity);
        }

        public PhraseTranslation Get(long id)
        {
            return _englishPhraseRepository.Entity(id);
        }

        public IList<PhraseTranslation> GetAll()
        {
            return _englishPhraseRepository.GetList();
        }
    }
}