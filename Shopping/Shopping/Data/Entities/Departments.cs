using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Departments
    {
        public int Id { get; set; }
        [Display(Name = "Departamentos")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required]
        public string Name { get; set; }
    }
}
