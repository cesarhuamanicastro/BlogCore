using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Slider
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre esl obligatorio")]
        [Display(Name = "Nombre de Slider")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Es Obligatorio")]

        public bool Estado { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

    }
}
