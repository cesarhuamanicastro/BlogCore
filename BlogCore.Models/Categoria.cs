using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese nombre para la categoria")]
        [Display(Name ="Nombre Categoria")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Orden de Visualizacion")]
        public string Orden { get; set; }
    }
}
