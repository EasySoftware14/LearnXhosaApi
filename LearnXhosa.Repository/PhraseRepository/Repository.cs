using System;
using System.Collections.Generic;
using System.Linq;
using LearnXhosa.Repository.InterfaceContracts;
using NHibernate;

namespace LearnXhosa.Repository.PhraseRepository
{
    public class Repository <T> : IRepository<T> where T: class
    {
        private readonly NhibernateHelper _nhibernateHelper;
        private ISession _session;

        public Repository()
        {
            _nhibernateHelper = new NhibernateHelper();
            _session = _nhibernateHelper.OpenSession();
        }
        public long AddEntity(T entity)
        {
            return Convert.ToInt32(_session.Save(entity));
        }

        public void Delete(T entity)
        {
            _session.Delete(entity);
        }

        public void Update(T entity)
        {
            _session.Update(entity);
        }

        public IList<T> GetList()
        {
            return _session.Query<T>().ToList();
        }

        public T Entity(long id)
        {
            return _session.Load<T>(id);
        }

        public IList<T> FindBySpecification(ICriteriaSpecification<T> specification)
        {
            return specification.Criteria(_session).List<T>();
        }
    }
}
