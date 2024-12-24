using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        [Display(Name = "Bodega")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Dirección")]
        public string Addres { get; set; } = string.Empty;
        [Display(Name = "Observaciones")]
        public string Remarks { get; set; } = string.Empty;
    }
}
