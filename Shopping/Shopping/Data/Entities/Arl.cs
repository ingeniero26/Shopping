using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Arl
    {
        public int Id { get; set; }

        [Display(Name = "Arl")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }
        [Display(Name = "Nit Arl")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nit { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
