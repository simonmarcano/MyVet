using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligtorio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

 //       public DateTime Disponible { get; set; } //TEMPORAL

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();

        public Owner Owner { get; set; }

        public Pet Pet { get; set; }
    }
}
