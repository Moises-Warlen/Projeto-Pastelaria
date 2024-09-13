using Pastelaria.Web.Application.Perfil;
using Pastelaria.Web.Infra;
using System.Web.Mvc;

namespace Pastelaria.Web.Controllers
{
    public class PerfilController : BaseController
    {
        private readonly PerfilApplication _perfilApplication;

        // GET: Perfil
        public PerfilController(PerfilApplication perfilApplication)
        {
            _perfilApplication = perfilApplication;
        }
        // GET: Perfil
        public ActionResult Index()
        {
            var response = _perfilApplication.GetPerfil();
            return View(response.Content); // Passa a lista de perfis para a view
        }
    }
}