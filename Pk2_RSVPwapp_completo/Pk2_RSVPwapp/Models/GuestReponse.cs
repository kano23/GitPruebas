using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//usado para validar campos
using System.ComponentModel.DataAnnotations;


namespace Pk2_RSVPwapp.Models
{
    public class GuestReponse
    {   
        [Required(ErrorMessage= "Por favor ingresa su nombre:")]
        public string Name { get; set; }
        
        [Required(ErrorMessage= "Por favor ingrese su correo electronico.")]
        [RegularExpression(".+\\@..+",
            ErrorMessage= "Favor de ingresar una cuenta de correo valida")]
        public string Email { get; set; }

        [Required(ErrorMessage= "Por favor ingrese su numero telefonico.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Por favor especifique si asistira o no.")]
        public bool? WillAttend { get; set; }
    }
}