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
    /// Class CustomerRepository.
    /// Implements the <see cref="RepositoryPattern.Repository.Interface.ICustomerRepository" />
    /// </summary>
    /// <seealso cref="RepositoryPattern.Repository.Interface.ICustomerRepository" />
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IDatabaseHelper _databaseHelper;

        public CustomerRepository(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }

        public Task<bool> Add(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 取得 Customer
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Customer>> Get(QueryCustomer dto)
        {
            // 資料庫實作
            using (IDbConnection conn = this._databaseHelper.GetConnection())
            {
                string sql = @"
                                SELECT
                                    CompanyId,
                                    CompanyName
                                FROM Customers
                                WHERE
                                    CompanyId = @CompanyId OR
                                    City = @City";

                var customers = await conn.QueryAsync<Customer>(
                    sql,
                    new
                    {
                        dto.CustomerId,
                        dto.City
                    });

                return customers;
            }
        }

        public Task<bool> Update(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}