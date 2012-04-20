using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ECommerce.Domain.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
        //where TContext : DbContext, new()
        
    {
        private DbSet<TEntity> _Dbset;
        private DbSet<TEntity> Dbset
        {
            get { return _Dbset ?? (_Dbset = Context.Set<TEntity>()); }
        }

        //private TContext _context;
        //private TContext Context
        //{
        //    get { return _context ?? (_context = new TContext()); }
        //}

        private ECommerceContext _context;
        private ECommerceContext Context
        {
            get { return _context ?? (_context = new ECommerceContext()); }
        }

        #region IRepository<TEntity> Members

        public void Inserir(TEntity t)
        {
            Dbset.Add(t);
            Context.SaveChanges();
        }

        public void Atualizar(TEntity t)
        {
            Context.SaveChanges();
        }

        public void Deletar(TEntity t)
        {
            Dbset.Remove(t);    
            Context.SaveChanges();
        }

        public TEntity BuscarPorId(object id)
        {
            var entity = Dbset.Find(id);
            return entity;
        }

        public IQueryable<TEntity> BuscarLista()
        {
            return Dbset;
        }

        #endregion
    }
}
