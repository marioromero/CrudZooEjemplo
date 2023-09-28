using CrudZooEjemplo.DTOs;
using CrudZooEjemplo.Models;
using CrudZooEjemplo.Responses;
using Org.BouncyCastle.Asn1.X509;

namespace CrudZooEjemplo.Services
{
    public class UsuariosService
    {
        public async Task<UsuariosResponse> ListaUsuarios()
        {
            UsuariosResponse response = new();
            using (var context = new grupoint_actividad_crudContext())
            {
                try
                {
                    await Task.Run(() =>
                    {
                        var usuarios = (from u in context.Usuarios
                                        select u).ToList();

                        response.Data = usuarios;
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

        public async Task<UsuarioResponse> CrearUsuario(UsuariosDTO data)
        {
            UsuarioResponse response = new();
            using (var context = new grupoint_actividad_crudContext())
            {
                try
                {
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

        public async Task<UsuarioResponse> EditarUsuario(UsuariosUpdateDTO data, int usuarioId)
        {
            UsuarioResponse response = new();
            using (var context = new grupoint_actividad_crudContext())
            {
                try
                {
                    await Task.Run(() =>
                    {
                        var usuario = (from u in context.Usuarios
                                       where u.Id == usuarioId
                                       select u).FirstOrDefault();

                        if (usuario != null)
                        {
                            //verifica si se envió el dato para actualizarlo

                            if (!string.IsNullOrEmpty(data.Nombre)) 
                            {
                                usuario.Nombre = data.Nombre;
                            }

                            if (!string.IsNullOrEmpty(data.Password))
                            {
                                usuario.Password = data.Password; //pendiente encriptar
                            }

                            context.SaveChanges();

                            response.Data = usuario;
                            response.Status = true;
                            response.Code = 200;
                            response.Message = "OK";
                        }
                        else
                        {
                            response.Status = false;
                            response.Code = 404;
                            response.Message = "Usuario no encontrado";
                        }
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
