using System.ComponentModel.DataAnnotations;

namespace CrudZooEjemplo.DTOs
{
    public class UsuariosDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras.")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El password es obligatorio.")]
        /*[MinLength(8, ErrorMessage = "El password debe tener al menos 8 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "El password debe tener al menos una mayúscula, una minúscula, un número y un caracter especial.")]*/
        public string Password { get; set; }
    }

    public class UsuariosUpdateDTO
    {
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras.")]
        public string? Nombre { get; set; }


        /*[MinLength(8, ErrorMessage = "El password debe tener al menos 8 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "El password debe tener al menos una mayúscula, una minúscula, un número y un caracter especial.")]*/
        public string? Password { get; set; }
    }
}
