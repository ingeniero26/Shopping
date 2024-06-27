using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Categories
    {
        public int Id { get; set; }
        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required]
        public string Name { get; set; }
    }
}
