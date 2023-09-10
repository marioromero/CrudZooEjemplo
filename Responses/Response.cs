using CrudZooEjemplo.Models;

namespace CrudZooEjemplo.Responses
{
    public class Response
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public object Data { get; set; }
    }

    public class UsuariosResponse : Response  //se usa para retornar en la data un objeto que contiene una lista de objetos de tipo Usuario
    {
        public List<Usuario> Data { get; set; }
    }

    public class UsuarioResponse : Response  //se usa para retornar en la data un objeto de tipo Usuario
    {
        public Usuario Data { get; set; }
    }
}
