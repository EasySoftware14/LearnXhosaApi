using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXhosa.Repository.InterfaceContracts
{
    public interface IRepository <T> where T: class 
    {
        long AddEntity(T entity);
        void Delete(T entity);
        void Update(T entity);
        IList<T> GetList();
        T Entity(long id);
        IList<T> FindBySpecification(ICriteriaSpecification<T> specification);
    }
}
