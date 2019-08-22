using System.Data;
using System.Data.SqlClient;

namespace RepositoryPattern.Repository.Infrastructure
{
    /// <summary>
    /// Database 介面
    /// </summary>
    /// <seealso cref="Evertrust.Mail.Repository.Infrastructure.IDatabaseConstants" />
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseHelper"/> class.
        /// </summary>
        /// <param name="database">The database.</param>
        public DatabaseHelper(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 取得連線
        /// </summary>
        /// <param name="dbName">連線 Key</param>
        /// <returns></returns>
        public IDbConnection GetConnection()
        {
            var conn = new SqlConnection(this._connectionString);

            return conn;
        }
    }
}