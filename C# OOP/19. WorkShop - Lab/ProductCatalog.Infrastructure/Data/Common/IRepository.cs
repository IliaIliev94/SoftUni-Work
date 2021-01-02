using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductCatalog.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        void Add<T>(T entity) where T : class;

        T GetById<T>(object id) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void Delete<T>(object id) where T : class;

        int SaveChanges();
    }
}
