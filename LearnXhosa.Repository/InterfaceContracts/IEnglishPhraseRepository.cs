using LearnXhosa.Implementation.Entities;
using NHibernate;

namespace LearnXhosa.Repository.InterfaceContracts
{
    public interface IEnglishPhraseRepository : IRepository<PhraseTranslation>
    {
        ISession Session { get; set; }
    }
}