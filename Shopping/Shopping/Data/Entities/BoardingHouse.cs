using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class BoardingHouse
    {
        private int Id { get; set; }
        [Display(Name = "Pensión")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }
        [Display(Name = "Nit Pensión")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NitBoardingHouse { get; set; }
        [Display(Name = "Dirección")]
        public string Address { get; set;}
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        [Display(Name = "Correo")]
        public string Email { get; set; }

    }
}
