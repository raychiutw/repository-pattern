using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using RepositoryPattern.Common.Enities;
using RepositoryPattern.Repository.Infrastructure;
using RepositoryPattern.Repository.Interface;

namespace RepositoryPattern.Repository.Implement
{
    /// <summary>
    /// Class FooRepository.
    /// Implements the <see cref="RepositoryPattern.Repository.Interface.IFooRepository" />
    /// </summary>
    /// <seealso cref="RepositoryPattern.Repository.Interface.IFooRepository" />
    public class FooRepository : IFooRepository
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IDatabaseHelper _databaseHelper;

        public FooRepository(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }

        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Foo>> Get(QueryFoo dto)
        {
            IEnumerable<Foo> foos;

            // 資料庫實作
            using (IDbConnection conn = this._databaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Foo";
                foos = await conn.QueryAsync<Foo>(sql);
            }

            return foos;
        }
    }
}