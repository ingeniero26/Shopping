using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class DocumentType
    {
        public int Id  { get; set; }
        [Display(Name = "Tipo Documento")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }
    }
}
