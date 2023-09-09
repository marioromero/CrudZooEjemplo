using System.ComponentModel.DataAnnotations;

namespace CrudZooEjemplo.DTOs
{
    public class UsuariosDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El password es obligatorio.")]
        public string Password { get; set; }
    }
}
