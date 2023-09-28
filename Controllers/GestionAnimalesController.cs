using CrudZooEjemplo.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CrudZooEjemplo.Controllers
{
    [Route("api/v1/gestion-animales-controller")] //define la ruta de la API
    [ApiController] //define que es un controlador de API
    public class GestionAnimalesController
    {
        [HttpPost("asignar-responsable-a-animales")]
        public bool AsignarResponsable([FromBody] AsignarResponsableDTO data)
        {
            //var response = await service.CrearUsuario(data);
            //return new JsonResult(response) { StatusCode = response.Code };
            return true;
        }

        [HttpPost("notificar-irresponsabilidad")]
        public bool NotificarIrresponsabilidad(string comentario)
        {
            //var response = await service.CrearUsuario(data);
            //return new JsonResult(response) { StatusCode = response.Code };
            return true;
        }
    }
}
