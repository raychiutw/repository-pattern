using RepositoryPattern.Common.Enum;

namespace RepositoryPattern.WebApi.Controllers.ViewModels
{
    /// <summary>
    /// Class FooViewModel.
    /// </summary>
    public class FooViewModel
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