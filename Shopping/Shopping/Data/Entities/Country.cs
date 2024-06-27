using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage =("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
