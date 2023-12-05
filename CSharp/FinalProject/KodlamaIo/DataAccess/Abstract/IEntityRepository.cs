using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new () 
    {
        public void Insert(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
        public List<TEntity>? GetList();
        public TEntity? GetById(int id);
       

        //tüm sınıflar için ortak olan metodlar yazılır.

    }
}
