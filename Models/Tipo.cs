using System;
using System.Collections.Generic;

namespace CrudZooEjemplo.Models
{
    public partial class Tipo
    {
        public Tipo()
        {
            Avestruces = new HashSet<Avestruz>();
            Cebras = new HashSet<Cebra>();
            Elefantes = new HashSet<Elefante>();
            Hipopotamos = new HashSet<Hipopotamo>();
            Jirafas = new HashSet<Jirafa>();
            Koalas = new HashSet<Koala>();
            Leones = new HashSet<Leon>();
            Lobos = new HashSet<Lobo>();
            Monos = new HashSet<Mono>();
            Panteras = new HashSet<Pantera>();
            Tiburones = new HashSet<Tiburon>();
            Tigres = new HashSet<Tigre>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Avestruz> Avestruces { get; set; }
        public virtual ICollection<Cebra> Cebras { get; set; }
        public virtual ICollection<Elefante> Elefantes { get; set; }
        public virtual ICollection<Hipopotamo> Hipopotamos { get; set; }
        public virtual ICollection<Jirafa> Jirafas { get; set; }
        public virtual ICollection<Koala> Koalas { get; set; }
        public virtual ICollection<Leon> Leones { get; set; }
        public virtual ICollection<Lobo> Lobos { get; set; }
        public virtual ICollection<Mono> Monos { get; set; }
        public virtual ICollection<Pantera> Panteras { get; set; }
        public virtual ICollection<Tiburon> Tiburones { get; set; }
        public virtual ICollection<Tigre> Tigres { get; set; }
    }
}
