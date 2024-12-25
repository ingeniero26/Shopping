using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class AddressTypeTable
    {
        public int Id { get; set; }
        [Display(Name = "Tipo Direccón")]
        [MaxLength(250, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string AddressType { get; set; } 

        
    }
}
