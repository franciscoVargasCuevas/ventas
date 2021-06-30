using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PACO.Models.ViewModels
{
    public class ArticuloViewModel
    {
        [Required]
        [Display(Name = "Identificador")]
        public int id { get; set; }
        [Required]
        [Display(Name = "Código")]
        [StringLength(50)]
        public string codigo { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        [StringLength(100)]
        public string descripcion { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public Double precio { get; set; }
        [Display(Name = "Imagen")]
        public byte[] imagen { get; set; }
        [Required]
        [Display(Name = "Stock")]
        public int stock{ get; set; }

    }
}