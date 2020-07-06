using Microsoft.AspNetCore.Mvc;

namespace GerenciadorCondominios.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult Index(){
            return View();
        }
        public ActionResult Registro(){
            return View();
        }        
    }
}