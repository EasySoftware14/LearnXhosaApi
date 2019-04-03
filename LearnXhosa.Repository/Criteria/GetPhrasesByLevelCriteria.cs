using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;
using NHibernate.Criterion;

namespace LearnXhosa.Repository.Criteria
{
    public class GetPhrasesByLevelCriteria : ICriteriaSpecification<Phrase>
    {
        private readonly PhraseLevel _phraseLevel;

        public GetPhrasesByLevelCriteria(PhraseLevel level)
        {
            _phraseLevel = level;
        }

        public ICriteria Criteria(ISession session)
        {
            var criteria = session.CreateCriteria(typeof(User));
            criteria.Add(Restrictions.Eq("level", _phraseLevel));

            return criteria;
        }
    }
}