using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;
using NHibernate.Criterion;

namespace LearnXhosa.Repository.Criteria
{
    public class GetUserByEmailCriteria : ICriteriaSpecification<User>
    {
        private readonly string _email;
        
        public GetUserByEmailCriteria(string email)
        {
            _email = email;
        }

        public ICriteria Criteria(ISession session)
        {
            var criteria = session.CreateCriteria(typeof(User));
            criteria.Add(Restrictions.Eq("email", _email));

            return criteria;
        }
    }
}