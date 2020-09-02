using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60, ErrorMessage = "Entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Entre 3 e 60 caracteres")]
        public string Title { get; set; }
    }
}