using System.Collections.Generic;
using System.Linq;
using LearnXhosa.Implementation.Entities;
using LearnXhosa.Repository.Criteria;
using LearnXhosa.Repository.InterfaceContracts;
using LearnXhosa.Repository.PhraseRepository;
using LearnXhosa.Services.Contracts;

namespace LearnXhosa.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public long Save(User entity)
        {
            using (var transaction = _userRepository.Session.BeginTransaction())
            {
                var id = _userRepository.AddEntity(entity);
                transaction.Commit();

                return id;
            }
           
        }

        public void Update(User entity)
        {
            using (var transaction = _userRepository.Session.BeginTransaction())
            {
                _userRepository.Update(entity);
                transaction.Commit();
            }
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public User Get(long id)
        {
            return _userRepository.Entity(id);
        }

        public IList<User> GetAll()
        {
            return _userRepository.GetList();
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.FindBySpecification(new GetUserByEmailCriteria(email)).Single();
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _userRepository.FindBySpecification(new GetUserByEmailAndPasswordCriteria(email, password)).Single();
        }
    }
}