using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Measures
    {
        public int Id { get; set; }
        [Display(Name = "Medida")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        [Display(Name = "Abreviatura")]
        public string Abbreviation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


    }
}
