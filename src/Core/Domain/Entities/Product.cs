using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public required Guid Id { get; set; }
        public required string? Name { get; set; }
        public required Guid FkCategoria { get; set; }
        public Category? Categoria { get; set; }
    }

    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string? Nome { get; set; }
    }
}
