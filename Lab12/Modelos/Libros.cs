using Lab12.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Libros : Producto
    {
        [Required]
        public string Editorial { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string Autor { get; set; }
    }
}