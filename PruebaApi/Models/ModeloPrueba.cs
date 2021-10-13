using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Models
{
    public class ModeloPrueba
    {
        [Key]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El {0} es requerido")]
        public string Tipo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El {0} es requerido")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe ser entre {2} y {1}")]
        public string Pelicula { get; set; }
    }
}
