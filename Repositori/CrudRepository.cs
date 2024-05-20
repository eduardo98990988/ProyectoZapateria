using DBModelZapateria;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori
{
    public class CrudRepository <TEntity> where TEntity : class
    {
        #region Inyeccion de Dependencias
        internal _dbZapateriaModelContext db;
        internal DbSet<TEntity> dbset;

        //Constructor
        public CrudRepository ()
        {
            db = new _dbZapateriaModelContext ();
            dbset = db.Set<TEntity>();
        }
        #endregion Fin Inyeccion de Dependencias
        #region Crud Hacia la Base de Datos
        public List<TEntity> GetAll ()
        {
            IQueryable<TEntity> query = dbset;
            return query.ToList ();
        }

        public TEntity GetByID (object id)
        {
            return dbset.Find(id);
        }

        public TEntity Create ( TEntity entity )
        {
            dbset.Add( entity );
            db.SaveChanges();
            return entity;
        }
        public TEntity Update ( TEntity entity )
        {
            dbset.Update( entity );
            db.SaveChanges();
            return entity;
        }
        public int Delete (object id)
        {
            TEntity? entitu = dbset.Find(id);
            db.Remove(entitu);
            return db.SaveChanges ();
                
        }
        public List<TEntity> CreateMultiple( List<TEntity> lista )
        {
            dbset.AddRange(lista);
            db.SaveChanges();
            return lista;
        }
        public List<TEntity> UpdateMultiple(List<TEntity> lista)
        {
            dbset.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }
        public int DeleteMultiple (List<TEntity> lista)
        {
            TEntity? entity = dbset.Find(lista);
            dbset.RemoveRange(entity);
            return db.SaveChanges();
        }
        public void Dispose ()
        {
            GC.SuppressFinalize (this);

        }
        #endregion Fin Crud Hacia la Base de Datos
    }
}
