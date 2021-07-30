using ByteBank.Forum.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ByteBank.Forum.Controllers
{
    public class ContaController : Controller
    {
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(ContaRegistrarViewModel modelo)
        {
            // Podemos Incluir o Usuário
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            // Deu Ruim
            return View(modelo);
        }
    }
}