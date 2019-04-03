using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;
using NHibernate.Criterion;

namespace LearnXhosa.Repository.Criteria
{
    public class GetUserByEmailAndPasswordCriteria : ICriteriaSpecification<User>
    {
        private readonly string _email;
        private readonly string _password;

        public GetUserByEmailAndPasswordCriteria(string email, string password)
        {
            _email = email;
            _password = password;
        }
        public ICriteria Criteria(ISession session)
        {
            var criteria = session.CreateCriteria(typeof(User));
            criteria.Add(Restrictions.Eq("email", _email));
            criteria.Add(Restrictions.Eq("password", _password));

            return criteria;
        }
    }
}
