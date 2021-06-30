using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PACO.Models.ViewModels
{
    public class ClienteViewModel
    {
      
        [Display(Name ="Identificador")]
        public int id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50)]
        public string nombre { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(50)]
        public string apellidos { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        [StringLength(50)]
        public string direccion { get; set; }

    }
}