using CrudZooEjemplo.DTOs;
using CrudZooEjemplo.Models;
using CrudZooEjemplo.Responses;

namespace CrudZooEjemplo.Services
{

    public class GestionAnimalesService
    {
        UsuariosService ServicioUsuarios = new UsuariosService();

        public async Task<UsuarioResponse> AsignarResponsableAAnimales(AsignarResponsableDTO data)
        {

            UsuarioResponse response = new();

            try
            {
                //validar que el usuario exista
                //Result se usa para obtener el resultado de una tarea asincrona 
                //Data hace referencia a la propiedad de la clase UsuarioResponse, que almacena un objeto de tipo Usuario
                Usuario usuarioExiste = ServicioUsuarios.ObtenerUsuario(data.Usuario).Result.Data;

                //validar que el usuario exista
                if (usuarioExiste == null)
                {
                    throw new Exception("el usuario no existe");
                }

                //validar que el usuario no esté asignado
                if (usuarioExiste.EstaAsignado)
                {
                    throw new Exception("El usuario ya está asignado");
                }

                //se instancia un objeto de tipo UsuariosUpdateDTO, para actualizar el usuario
                var usuarioAsignado = new UsuariosUpdateDTO
                {
                    EstaAsignado = true
                };

                //se utiliza servicio de usuarios para actualizar el usuario, pasando como parámetro el objeto usuarioAsignado y el id del usuario  
                var asignacionUsuario = ServicioUsuarios.EditarUsuario(usuarioAsignado, data.Usuario);


                //hagamos cuenta que cada animal tiene un código
                int codigo;
                switch (data.Animales)
                {
                    case "jirafas":
                        codigo = 1;
                        break;
                    case "elefantes":
                        codigo = 2;
                        break;
                    //etc........
                    default:
                        codigo = 0;
                        break;
                }

                //si es 0, es porque no se encontró el animal
                if (codigo == 0)
                {
                    throw new Exception("el animal no existe");
                }

                RegistroResponsable registro = new()
                {
                    UsuarioId = data.Usuario,
                    AnimalId = codigo,
                    Fecha = DateOnly.FromDateTime(DateTime.Now)
                    //si fuera datetime, se usa: fecha = DateTime.Now 
                };

                //guardar registro en la base de datos
                using (var context = new grupoint_actividad_crudContext())
                {
                    context.RegistroResponsables.Add(registro);
                    context.SaveChanges();
                }

                response.Status = true;
                response.Code = 200;
                response.Message = "OK";
         
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Code = 400;
                response.Message = "Error: " + ex.Message;
            }

            return response;
        }
    }
}
