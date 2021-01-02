using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProductCatalog.Infrastructure.Data.Common
{
    public class ListRepository : IRepository
    {
        private List<object> dbSets = new List<object>();

        protected List<T> DbSet<T>() where T : class
        {
            object dbset = this.dbSets.FirstOrDefault(set => set.GetType() == typeof(List<T>));

            if(dbset == null)
            {
                dbset = new List<T>();
                dbSets.Add(dbset);
            }
            return dbset as List<T>;
        }
        public void Add<T>(T entity) where T : class
        {
            DbSet<T>().Add(entity);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public void Delete<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
        }

        public void Delete<T>(object id) where T : class
        {
            DbSet<T>().Remove(DbSet<T>().FirstOrDefault(set => set == id));
        }

        public void Dispose()
        {
            dbSets = null;
        }

        public T GetById<T>(object id) where T : class
        {

            return DbSet<T>().FirstOrDefault(set => GetKeyPropertyName<T>() == id)
        }

        public int SaveChanges()
        {
            return 1;
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        private string GetKeyPropertyName<T>() where T : class
        {
            string keyProperty = null;
            var properties = typeof(T).GetProperties();
            foreach(var property in properties)
            {
                if (Attribute.IsDefined(property, typeof(KeyAttribute)))
                {
                    keyProperty = property.Name;
                    break;
                }
            }

            if(keyProperty == null)
            {
                foreach(var property in properties)
                {
                    if(property.Name.ToLower() == "id")
                    {
                        keyProperty = property.Name;
                        break;
                    }
                }
            }
            if(keyProperty == null)
            {
                throw new MemberAccessException("No key property found.");
            }
            return keyProperty;
        }
    }
}
