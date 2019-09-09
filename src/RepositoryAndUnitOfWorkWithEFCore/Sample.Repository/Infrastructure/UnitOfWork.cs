using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        /// 建構式
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(DbContext context)
        {
            this.Context = context;
        }

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