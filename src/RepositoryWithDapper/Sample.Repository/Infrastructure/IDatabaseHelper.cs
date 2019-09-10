using System.Data;

namespace Sample.Repository.Infrastructure
{
    /// <summary>
    /// Database 介面
    /// </summary>
    public interface IDatabaseHelper
    {
        /// <summary>
        /// 取得連線
        /// </summary>
        /// <returns></returns>
        IDbConnection GetConnection();
    }
}