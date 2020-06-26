using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligtorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligtorio")]
        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

        public ServiceType ServiceType { get; set; }

        public Pet Pet { get; set; }
    }
}
