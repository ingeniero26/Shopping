﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        [Display(Name = "Sucursal")]
        [MaxLength(50, ErrorMessage = ("El campo  debe tener un  {1} máximo de caracteres "))]
        [Required]
        public string Name { get; set; }
    }
}