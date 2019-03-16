using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]//se ha requerido el double
        [Display(Name ="Nombre del Producto")]//con lo identificamos el producto

        public string Nombre { get; set; }

        public double Precio { get; set; }
    }
}