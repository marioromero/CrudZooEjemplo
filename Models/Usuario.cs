using System;
using System.Collections.Generic;

namespace CrudZooEjemplo.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Tipos = new HashSet<Tipo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Tipo> Tipos { get; set; }
    }
}
