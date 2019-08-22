using RepositoryPattern.Common.Enum;

namespace RepositoryPattern.Common.Dto
{
    /// <summary>
    /// Class FooDto.
    /// </summary>
    public class FooDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public FooEnum Type { get; set; }
    }
}