using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60, ErrorMessage = "Entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Entre 3 e 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Máximo de 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}