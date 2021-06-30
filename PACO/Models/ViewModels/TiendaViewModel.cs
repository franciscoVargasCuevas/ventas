using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PACO.Models.ViewModels
{
    public class TiendaViewModel
    {
        [Required]
        [Display(Name ="Identificador")]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Sucursal")]
        public string sucursal { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Direccíón")]
        public string direccion { get; set; }


    }
}