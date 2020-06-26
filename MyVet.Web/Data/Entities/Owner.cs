﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligtorio")]
        //[MaxLength(30, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        //public string Document { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligtorio")]
        //[MaxLength(50, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        //[Display(Name = "First Name")]
        //public string FirstName { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligtorio")]
        //[MaxLength(35, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; }

        //[MaxLength(20, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        //[Display(Name = "Fixed Phone")]
        //public string FixedPhone { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligtorio")]
        //[MaxLength(20, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        //[Display(Name = "Cell Phone")]
        //public string CellPhone { get; set; }

        //[MaxLength(100, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        //public string Address { get; set; }

        //[Display(Name = "Owner")]
        //public string FullName => $"{FirstName} {LastName}";

        //[Display(Name = "Owner")]
        //public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public User User { get; set; }

        //RELACIONES DE 1 a N

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
