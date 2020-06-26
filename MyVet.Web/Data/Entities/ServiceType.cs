using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligtorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [Display(Name = "Service Type")]
        public string Name { get; set; }

        public ICollection<History> Histories { get; set; }
    }
}
