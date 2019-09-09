using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sample.Repository.Infrastructure
{
    /// <summary>
    /// UnitOfWork 介面
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// DB Context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// Saves the change.
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangeAsync();
    }
}