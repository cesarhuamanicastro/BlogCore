﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;




namespace BlogCore.Models
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre esl obligatorio")]
        [Display(Name ="Nombre de Articulo")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "La descripcion es obligatorio")]
     
        public string Descripcion { get; set; }
     



        [Display(Name = "Fecha de Creacion")]
        public string FechaCreacion { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        [Required]
        [Display(Name = "Seleccione una Categoria")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }


    }
}
