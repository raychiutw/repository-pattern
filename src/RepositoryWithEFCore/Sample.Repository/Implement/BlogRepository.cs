using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample.Common.Enities;
using Sample.Repository.Db;
using Sample.Repository.Interface;

namespace Sample.Repository.Implement
{
    /// <summary>
    /// Class BlogRepository.
    /// Implements the <see cref="Sample.Repository.Interface.IBlogRepository" />
    /// </summary>
    /// <seealso cref="Sample.Repository.Interface.IBlogRepository" />
    public class BlogRepository : IBlogRepository
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly BloggingContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BlogRepository(BloggingContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blog">實體</param>
        /// <returns></returns>
        public async Task<bool> AddAsync(Blog blog)
        {
            _context.Add(blog);
            var count = await _context.SaveChangesAsync();

            return count > 0;
        }

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="condition">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Blog>> GetAsync(BlogQuery condition)
        {
            var blogs = await _context.Blog.ToListAsync();
            return blogs;
        }

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="id">blog id</param>
        /// <returns></returns>
        public async Task<bool> RemoveAsync(int id)
        {
            var blog = await _context.Blog.FindAsync(id);
            _context.Blog.Remove(blog);
            var count = await _context.SaveChangesAsync();

            return count > 0;
        }

        /// <summary>
        /// 更新 Blog
        /// </summary>
        /// <param name="blog">實體</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(Blog blog)
        {
            _context.Update(blog);
            var count = await _context.SaveChangesAsync();

            return count > 0;
        }
    }
}