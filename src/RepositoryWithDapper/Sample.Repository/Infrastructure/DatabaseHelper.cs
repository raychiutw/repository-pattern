using System.Data;
using System.Data.SqlClient;

namespace Sample.Repository.Infrastructure

{
    /// <summary>
    /// DatabaseHelper
    /// </summary>
    /// <seealso cref="Sample.Repository.Infrastructure.IDatabaseHelper" />
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseHelper"/> class.
        /// </summary>
        /// <param name="connectionString">The database.</param>
        public DatabaseHelper(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 取得連線
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetConnection()
        {
            var conn = new SqlConnection(this._connectionString);

            return conn;
        }
    }
}