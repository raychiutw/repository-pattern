using Microsoft.EntityFrameworkCore;

namespace Sample.Repository.Infrastructure
{
    /// <summary>
    /// IDbContextFactory
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