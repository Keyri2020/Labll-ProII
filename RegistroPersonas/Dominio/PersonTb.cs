using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using RegistroPersonas.Data;
using RegistroPersonas.Repository;
using RegistroPersonas.Service;

namespace RegistroPersonas.Dominio
{
    public class PersonTb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPersona { get; set; }

        [Display(Name = "NombrePersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string NombrePersona { get; set; }

        [Display(Name = "EdadPersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(18, 120, ErrorMessage = "Solo mayores de 18 años")]
        public int EdadPersona { get; set; }

        [Display(Name = "DescripcionPersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string DescripcionPersona { get; set; }

    }
}