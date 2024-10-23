using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Produto
    {
        [Key]
        public required Guid Id { get; set; }
        public required string? Nome { get; set; }
        public required Guid FkCategoria { get; set; }
    }

    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
