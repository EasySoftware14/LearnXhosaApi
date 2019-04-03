using System.Collections;
using System.Collections.Generic;
using LearnXhosa.Implementation.Entities;

namespace LearnXhosa.Services.Contracts
{
    public interface IXhosaPhraseService : IRepositoryService<Phrase>
    {
        IList<Phrase> GetXhosaPhrasesByLevel(PhraseLevel level);
    }
}