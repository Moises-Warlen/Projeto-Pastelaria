using Pastelaria.Api.Infra.Configuration;
using Pastelaria.Domain.Usuario;
using System.Web.Http;

namespace Pastelaria.Api.Controllers
{

    // Controlador responsável por gerenciar operações relacionadas aos usuários da aplicação.
    [RoutePrefix("api/usuario")] // Define um prefixo de rota para todos os endpoints deste controlador.
    public class UsuarioController :  AuthApiController
    {
        // Repositórios utilizados para acessar e manipular dados relacionados a usuários, endereços e telefones.
        private readonly IUsuarioRepository _usuarioRepository;
        // Construtor que recebe instâncias dos repositórios para operações de CRUD.
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
           
        }
        // Endpoint para obter todos os usuários.
        [HttpGet, Route("todos")]
        public IHttpActionResult GetUsuarios()
        {
            var usuarios = _usuarioRepository.Get();
            return Ok(usuarios);
        }
    }
}