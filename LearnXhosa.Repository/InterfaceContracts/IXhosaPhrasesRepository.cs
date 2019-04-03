using System.Collections.Generic;
using LearnXhosa.Implementation.Entities;
using NHibernate;

namespace LearnXhosa.Repository.InterfaceContracts
{
    public interface IXhosaPhrasesRepository : IRepository<Phrase>
    {
        List<Phrase> GetPhraseByLevel(PhraseLevel level);
        ISession Session { get; set; }
    }
}