using CrudZooEjemplo.DTOs;
using CrudZooEjemplo.Models;
using CrudZooEjemplo.Responses;

namespace CrudZooEjemplo.Services
{

    public class GestionAnimalesService
    {

        public async Task<UsuarioResponse> AsignarResponsableAAnimales(AsignarResponsableDTO data)
        {
            var ServicioUsuarios = new UsuariosService();


            UsuarioResponse response = new();
            using (var context = new grupoint_actividad_crudContext())
            {
                try
                {

                    Usuario usuarioExiste = ServicioUsuarios.ObtenerUsuario(data.Usuario);

                    if (usuarioExiste == null) 
                    {
                        throw new Exception("el suaurui no existe");
                    }

                    await Task.Run(() =>
                    {

                        var nombreOcupado = (from u in context.Usuarios
                                             where u.Nombre == data.Nombre
                                             select u.Nombre).FirstOrDefault();

                        if (nombreOcupado != null)
                        {
                            throw new Exception("Nombre de usuario ya registrado.");
                        }

                        Usuario usuario = new()
                        {
                            Nombre = data.Nombre,
                            Password = data.Password, //pendiente encriptar
                        };

                        context.Usuarios.Add(usuario);
                        context.SaveChanges();


                        response.Data = usuario;
                        response.Status = true;
                        response.Code = 200;
                        response.Message = "OK";
                    });
                }
                catch (Exception ex)
                {
                    response.Status = false;
                    response.Code = 400;
                    response.Message = "Error: " + ex.Message;
                }
            }
            return response;
        }
    }
}
