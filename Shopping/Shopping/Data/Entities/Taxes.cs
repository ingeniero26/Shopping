using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Taxes
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required(ErrorMessage = "Debe digitar una unidad de medida")]
        public string Description { get; set; }

        public double Rate { get; set; }
    }
}
