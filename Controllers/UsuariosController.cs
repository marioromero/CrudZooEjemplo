using CrudZooEjemplo.DTOs;
using CrudZooEjemplo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudZooEjemplo.Controllers
{
    [Route("api/v1/usuarios-controller")] //define la ruta de la API
    [ApiController] //define que es un controlador de API
    public class UsuariosController
    {
        UsuariosService service = new();

        [HttpPost("crear-usuario")]
        public async Task<IActionResult> CrearUsuario([FromBody] UsuariosDTO data)
        {
            var response = await service.CrearUsuario(data);
            return new JsonResult(response) { StatusCode = response.Code };
        }

        [HttpGet("lista-usuario")]
        public async Task<IActionResult> ListaUsuarios()
        {
            var response = await service.ListaUsuarios();
            return new JsonResult(response) { StatusCode = response.Code };
        }

        [HttpPut("editar-usuario")]
        public async Task<IActionResult> EditarUsuario([FromBody] UsuariosUpdateDTO data, int usuarioId)
        {
            var response = await service.EditarUsuario(data, usuarioId);
            return new JsonResult(response) { StatusCode = response.Code };
        }
    }
}
