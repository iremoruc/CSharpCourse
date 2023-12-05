using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfGenericRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : class,IEntity, new()
    {
        // new keywordü referans oluşturur - garbage collector - disposeable pattern
       // private readonly Context _context = new Context(); //burda bu şekilde oluşturdum başka bi değer atanmıcak-readonly
        public void Delete(TEntity entity)
        {
            using Context _context = new Context();
            _context.Remove(entity);
            _context.SaveChanges();
        }
        //state
        public TEntity? GetById(int id) //int türünde değer sönmezse hata vermesin diye 
        {
            using Context _context = new Context();
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity>? GetList()
        {
            using Context _context = new Context();
            return _context.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            using Context _context = new Context();
            _context.Add(entity);
            _context.SaveChanges(); // Veritabanına kaydediyor.
        }

        public void Update(TEntity entity)
        {
            using Context _context = new Context();
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
