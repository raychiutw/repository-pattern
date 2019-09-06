using Microsoft.EntityFrameworkCore;

namespace Sample.Repository.Infrastructure.ContextFactory
{
    /// <summary>
    /// DbContextFactory 介面
    /// </summary>
    public interface IDbContextFactory
    {
        /// <summary>
        /// 取得 DbContext
        /// </summary>
        /// <returns></returns>
        DbContext GetDbContext();
    }
}