using System;
using System.Collections.Generic;

namespace CrudZooEjemplo.Models
{
    public partial class RegistroResponsable
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AnimalId { get; set; }
        public DateOnly Fecha { get; set; }
    }
}
