using System.Collections.Generic;

namespace Sample.Common.Enities
{
    /// <summary>
    /// Blog
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Blog"/> class.
        /// </summary>
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        /// <summary>
        /// Blog 編號
        /// </summary>
        public int BlogId { get; set; }

        /// <summary>
        /// 貼文集合
        /// </summary>
        public virtual ICollection<Post> Post { get; set; }

        /// <summary>
        /// Blog Url
        /// </summary>
        public string Url { get; set; }
    }
}