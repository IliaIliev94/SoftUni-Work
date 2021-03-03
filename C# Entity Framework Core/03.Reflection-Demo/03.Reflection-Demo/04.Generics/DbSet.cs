namespace GenericsDemo
{
    using System.Collections.Generic;

    public class DbSet<TEntity>
    {
        private ICollection<TEntity> entites;

        public DbSet()
        {
            this.entites = new List<TEntity>();
        }

        public int Count => this.entites.Count;

        public void Add(TEntity entity)
        {
            this.entites.Add(entity);
        }
    }
}
