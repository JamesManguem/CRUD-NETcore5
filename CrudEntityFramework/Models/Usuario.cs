using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es Obligatorio")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "El Celular es Obligatorio")]
        public string Celular { get; set; }


        [Required(ErrorMessage = "El e-mail es Obligatorio")]
        public string Email { get; set; }


       
    }
}
