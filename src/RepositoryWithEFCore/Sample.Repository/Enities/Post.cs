namespace Sample.Repository.Enities
{
    /// <summary>
    /// Post
    /// </summary>
    public class Post
    {
        /// <summary>
        /// 所屬 Blog
        /// </summary>
        public virtual Blog Blog { get; set; }

        /// <summary>
        /// Blog 編號
        /// </summary>
        public int BlogId { get; set; }

        /// <summary>
        /// 內文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 貼文編號
        /// </summary>
        public int PostId { get; set; }

        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
    }
}