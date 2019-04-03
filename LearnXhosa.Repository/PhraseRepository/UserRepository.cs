using System.Linq;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.Criteria;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;

namespace LearnXhosa.Repository.PhraseRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public ISession Session { get; set; }

        public UserRepository()
        {
            var nhibernateHelper = new NhibernateHelper();
            Session = nhibernateHelper.OpenSession();
        }

        public User GetUserByEmail(string email)
        {
            return FindBySpecification(new GetUserByEmailCriteria(email)).Single();
        }

        public User GetUserByEmailAndPassword(string username, string password)
        {
            return FindBySpecification(new GetUserByEmailAndPasswordCriteria(username, password)).Single();
        }
        
    }
}
