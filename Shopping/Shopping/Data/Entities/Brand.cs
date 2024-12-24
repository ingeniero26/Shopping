using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
