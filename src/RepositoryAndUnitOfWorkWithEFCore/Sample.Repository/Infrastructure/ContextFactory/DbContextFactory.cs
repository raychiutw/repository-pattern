using System;
using Microsoft.EntityFrameworkCore;

namespace Sample.Repository.Infrastructure.ContextFactory
{
    /// <summary>
    /// DbContextFactory
    /// </summary>
    /// <seealso cref="Sample.Repository.Infrastructure.ContextFactory.IDbContextFactory" />
    public class DbContextFactory : IDbContextFactory
    {
        private readonly string _connectionString;

        /// <summary>
        /// The database context
        /// </summary>
        private DbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbContextFactory"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public DbContextFactory(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        private DbContext DbContext
        {
            get
            {
                var optionsBuilder = new DbContextOptionsBuilder();
                optionsBuilder.UseSqlServer(this._connectionString);

                if (this._dbContext == null)
                {
                    Type t = typeof(DbContext);
                    this._dbContext =
                        (DbContext)Activator.CreateInstance(t, optionsBuilder.Options);
                }
                return _dbContext;
            }
        }

        /// <summary>
        /// 取得 DbContext
        /// </summary>
        /// <returns></returns>
        public DbContext GetDbContext()
        {
            return this.DbContext;
        }
    }
}