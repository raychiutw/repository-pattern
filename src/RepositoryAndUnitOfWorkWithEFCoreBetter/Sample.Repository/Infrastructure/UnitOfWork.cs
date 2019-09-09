using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample.Common.Enities;
using Sample.Repository.Interface;

namespace Sample.Repository.Infrastructure
{
    /// <summary>
    /// UnitOfWork
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        ///
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="blogRepository">The blog repository.</param>
        public UnitOfWork(
            DbContext context,
            IGenericRepository<Blog> blogRepository)
        {
            this.Context = context;
            this.BlogRepository = blogRepository;
        }

        /// <summary>
        /// </summary>
        public IGenericRepository<Blog> BlogRepository { get; private set; }

        /// <summary>
        /// Context
        /// </summary>
        public DbContext Context { get; private set; }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// SaveChange
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangeAsync()
        {
            return await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.Context.Dispose();
                    this.Context = null;
                }
            }
            this.disposed = true;
        }
    }
}