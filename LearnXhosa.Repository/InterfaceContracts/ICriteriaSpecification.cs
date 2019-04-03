using NHibernate;

namespace LearnXhosa.Repository.InterfaceContracts
{
    public interface ICriteriaSpecification <T>
    {
        ICriteria Criteria(ISession session);
    }
}