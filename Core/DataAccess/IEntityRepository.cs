using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//Generic Constraint
//class : referans tip olabilir
//IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
//new : yenilenebilir olmalı, IEntity koyamayız
namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
