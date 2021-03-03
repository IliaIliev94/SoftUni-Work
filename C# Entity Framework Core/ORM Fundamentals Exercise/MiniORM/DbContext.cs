using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace MiniORM
{
	// TODO: Create your DbContext class here.
	public abstract class DbContext
	{
		private readonly DatabaseConnection connection;

		private readonly Dictionary<Type, PropertyInfo> dbSetProperties;

		internal static readonly Type[] AllowedSqlTypes =
		{
			typeof(string),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(decimal),
			typeof(bool),
			typeof(DateTime)
		};

		protected DbContext(string connectionString)
		{
			this.connection = new DatabaseConnection(connectionString);

			this.dbSetProperties = this.DiscoverDbSets();

			using(new ConnectionManager(this.connection))
			{
				this.InitializeDbSets();
			}

			this.MapAllRelations();
		}

		public void SaveChanges()
		{
			var dbSets = this.dbSetProperties
				.Select(pi => pi.Value.GetValue(this));

			foreach(IEnumerable<object> dbSet in dbSets)
			{
				var invalidEntities = dbSet
					.Where(entity => !IsObjectValid(entity))
					.ToArray();

				if(invalidEntities.Any())
				{
					throw new InvalidOperationException($"{invalidEntities.Length} invalid entities found in {dbSet.GetType().Name}");
				}

			}

			using (new ConnectionManager(this.connection))
			{
				using (var transaction = this.connection.StartTransaction())
				{
					foreach (IEnumerable dbSet in dbSets)
					{
						var dbSetType = dbSet.GetType().GetGenericArguments().First();

						var persistMethod = typeof(DbContext)
							.GetMethod("Persist", BindingFlags.Instance | BindingFlags.NonPublic)
						.MakeGenericMethod(dbSetType);

						try
						{
							persistMethod.Invoke(this, new object[] { dbSet });
						}
						catch(TargetException tie)
						{
							throw tie.InnerException;
						}
						catch(InvalidOperationException)
						{
							transaction.Rollback();
							throw;
						}
						catch(SqlException)
						{
							transaction.Rollback();
						}
					}
					transaction.Commit();
				}
			}
		}

		private void Persist<TEntity>(DbSet<TEntity> dbSet)
			where TEntity: class, new()
		{
			var tableName = GetTableName(typeof(TEntity));

			var columns = this.connection.FetchColumnNames(tableName).ToArray();

			if(dbSet.ChangeTracker.Added.Any())
			{
				this.connection.InsertEntities(dbSet.ChangeTracker.Added, tableName, columns);
			}

			var modifiedEntities = dbSet.ChangeTracker.GetModifiedEntities(dbSet).ToArray();

			if(modifiedEntities.Any())
			{
				this.connection.UpdateEntities(modifiedEntities, tableName, columns);
			}

			if(dbSet.ChangeTracker.Removed.Any())
			{
				this.connection.DeleteEntities(dbSet.ChangeTracker.Removed, tableName, columns);
			}
		}

		private void InitializeDbSets()
		{
			foreach(var dbSet in this.dbSetProperties)
			{
				var dbSetType = dbSet.Key;
				var dbSetProperty = dbSet.Value;

				var populateDbSetGeneric = typeof(DbContext)
					.GetMethod("PopulateDbSet", BindingFlags.Instance | BindingFlags.NonPublic)
					.MakeGenericMethod(dbSetType);

				populateDbSetGeneric.Invoke(this, new object[] { dbSetProperty });
			}
		}
	}
}