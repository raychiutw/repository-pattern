using Microsoft.EntityFrameworkCore;

namespace Sample.Repository.Implement
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="Sample.Repository.Implement.GenericRepository{TEntity}" />
    public class BlogRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">db context.</param>
        public BlogRepository(DbContext context) : base(context)
        {
        }
    }
}