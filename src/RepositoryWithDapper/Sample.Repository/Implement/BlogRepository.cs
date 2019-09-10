using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Sample.Common.Enities;
using Sample.Repository.Infrastructure;
using Sample.Repository.Interface;

namespace Sample.Repository.Implement
{
    /// <summary>
    /// BlogRepository
    /// </summary>
    public class BlogRepository : IBlogRepository
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IDatabaseHelper _databaseHelper;

        /// <summary>
        ///
        /// </summary>
        /// <param name="databaseHelper"></param>
        public BlogRepository(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }

        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blog">Blog 實體</param>
        /// <returns></returns>
        public async Task<int> AddAsync(Blog blog)
        {
            // 資料庫實作
            using (IDbConnection conn = this._databaseHelper.GetConnection())
            {
                string sql = @"
                                INSERT INTO Blog
                                VALUES (
                                    @BlogId,
                                    @Url
                                );";

                var count = await conn.ExecuteAsync(
                    sql,
                    new
                    {
                        blog.BlogId,
                        blog.Url
                    });

                return count;
            }
        }

        /// <summary>
        /// 取得所有 Blog
        /// </summary>
        /// <param name="blogQuery">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Blog>> GetAsync(BlogQuery blogQuery)
        {
            // 資料庫實作
            using (IDbConnection conn = this._databaseHelper.GetConnection())
            {
                string sql = @"
                                SELECT
                                    BlogId,
                                    Url
                                FROM Blog
                                WHERE
                                    BlogId = @BlogId OR
                                    Url = @Url";

                var Blogs = await conn.QueryAsync<Blog>(
                    sql,
                    new
                    {
                        blogQuery.BlogId,
                        blogQuery.Url
                    });

                return Blogs;
            }
        }

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blog">Blog 實體</param>
        /// <returns></returns>
        public async Task<int> RemoveAsync(Blog blog)
        {
            // 資料庫實作
            using (IDbConnection conn = this._databaseHelper.GetConnection())
            {
                string sql = @"DELETE FROM Blog WHERE BlogId = @BlogId";

                var count = await conn.ExecuteAsync(
                    sql,
                    new
                    {
                        blog.BlogId
                    });

                return count;
            }
        }

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="blog">Blog 實體</param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(Blog blog)
        {
            // 資料庫實作
            using (IDbConnection conn = this._databaseHelper.GetConnection())
            {
                string sql = @"
                                UPDATE Blog
                                SET
                                    BlogId = @BlogId,
                                    Url = @Url
                                );";

                var count = await conn.ExecuteAsync(
                    sql,
                    new
                    {
                        blog.BlogId,
                        blog.Url
                    });

                return count;
            }
        }
    }
}