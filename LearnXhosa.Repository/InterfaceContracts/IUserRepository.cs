using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnXhosa.Implementation.Entities;
using NHibernate;

namespace LearnXhosa.Repository.InterfaceContracts
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByEmail(string email);
        User GetUserByEmailAndPassword(string username, string password);
        ISession Session { get; set; }
    }

}
