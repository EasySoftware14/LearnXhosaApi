using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using LearnXhosa.Repository.PhraseRepository;
using LearnXhosa.Services.Contracts;

namespace LearnXhosa.Services.Services
{
    public class XhosaPhraseService : IRepositoryService<Phrase>, IXhosaPhraseService
    {
        private readonly IXhosaPhrasesRepository _xhosaPhrasesRepository;

        public XhosaPhraseService()
        {
            _xhosaPhrasesRepository = new XhosaPhrasesRepository();
        }

        public long Save(Phrase entity)
        {
            return _xhosaPhrasesRepository.AddEntity(entity);
        }

        public void Update(Phrase entity)
        {
            _xhosaPhrasesRepository.Update(entity);
        }

        public void Delete(Phrase entity)
        {
            _xhosaPhrasesRepository.Delete(entity);
        }

        public Phrase Get(long id)
        {
            return _xhosaPhrasesRepository.Entity(id);
        }

        public IList<Phrase> GetAll()
        {
            return _xhosaPhrasesRepository.GetList();
        }

        public IList<Phrase> GetXhosaPhrasesByLevel(PhraseLevel level)
        {
            throw new NotImplementedException();
        }
    }
}
