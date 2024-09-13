
using Pastelaria.Api.Infra.Configuration;
using Pastelaria.Domain.Perfil;
using System.Web.Http;

namespace Pastelaria.Api.Controllers
{
    [RoutePrefix("api/perfil")] // Define o prefixo da rota para o controlador como "api/perfil"
    public class PerfilController : AuthApiController
    {
        // Declaração do repositório de perfis que será utilizado para acessar os dados
        private readonly IPerfilRepository _perfilRepository;

        // Construtor que recebe uma instância de IPerfilRepository para injeção de dependência
        public PerfilController(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

        // Método GET para obter todos os perfis
        [HttpGet, Route("todos")] // Define a rota para o método como "api/perfil/todos"
        public IHttpActionResult GetAllPerfil()

        {
            // Chama o método Get do repositório para obter os perfis
            return Ok(_perfilRepository.Get()); // Retorna os perfis com status HTTP 200 (OK)
        }
    }
}