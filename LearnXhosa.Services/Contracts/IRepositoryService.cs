﻿using System.Collections.Generic;

namespace LearnXhosa.Services.Contracts
{
    public interface IRepositoryService <T>
    {
        long Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(long id);
        IList<T> GetAll();
    }
}