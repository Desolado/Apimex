using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apimex.Models
{
    public class EmpresasCE
    {
        public long id_Empresa { get; set; }
        [Required]
        [Display(Name = "Ingrese el nombre de la empresa.")]
        public string Nombre { get; set; }
        public string Razon { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        public string Folio { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    }
}