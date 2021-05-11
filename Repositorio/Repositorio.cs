using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using System;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dominio.Entidades;

namespace Repositorio
{
    public abstract class Repositorio<TEntidade> : DbContext, IRepositorio<TEntidade> where TEntidade : EntityBase, new()
    {
        protected DbContext Db;
        protected DbSet<TEntidade> DbSetContext;
        public Repositorio(DbContext dbContext)
        {
            Db = dbContext;
            DbSetContext = Db.Set<TEntidade>();
        }

        public void Create(TEntidade Entity)
        {
            if(Entity.Codigo == null)
            {
                DbSetContext.Add(Entity);
            }
            else
            {
                DbSetContext.Update(Entity);
            }

            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            TEntidade ent = DbSetContext.Where(x => x.Codigo == id).FirstOrDefault();
            DbSetContext.Remove(ent);
            Db.SaveChanges();
        }

        public TEntidade Read(int id)
        {
            return DbSetContext.Where(x => x.Codigo == id).FirstOrDefault();
        }

        public virtual IEnumerable<TEntidade> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
