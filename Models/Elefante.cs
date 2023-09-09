using System;
using System.Collections.Generic;

namespace CrudZooEjemplo.Models
{
    public partial class Elefante
    {
        public int Id { get; set; }
        public int? TipoId { get; set; }
        public string? Apodo { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public int? EdadIngreso { get; set; }
        public bool? EsPeligroso { get; set; }

        public virtual Tipo? Tipo { get; set; }
    }
}
