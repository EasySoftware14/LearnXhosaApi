using LearnXhosa.Implementation.Entities;

namespace LearnXhosa.Services.Contracts
{
    public interface IUserService : IRepositoryService<User>
    {
        User GetUserByEmail(string email);
        User GetUserByEmailAndPassword(string email, string password);
    }
}