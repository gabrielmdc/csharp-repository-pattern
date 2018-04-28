using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryPattern.repositories
{
    public interface IRepository<TModel> where TModel : class
    {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);
        void Add(TModel model);
        void AddRange(IEnumerable<TModel> models);

        void Remove(TModel model);
        void RemoveRange(IEnumerable<TModel> models);
    }
}