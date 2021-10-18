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

        public string NombrePersona { get; set; }

        public int EdadPersona { get; set; }


        public string DescripcionPersona { get; set; }

    }
}