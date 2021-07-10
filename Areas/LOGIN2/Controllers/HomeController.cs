using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.LOGIN2.Controllers
{
    [Area("LOGIN2")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "omartel@esan.edu.pe" && password == "aprobar123")
                
            {
                return RedirectToAction("Index", "Publicaciones", new { area = "Postulante" });
            }
            if (email == "wmendoza@esan.edu.pe" && password == "hola123")
            {
                return RedirectToAction("Index", "Publicaciones", new { area = "Empresa" });
            }
            if (email == "lvillacrez@esan.edu.pe" && password == "desweb21")
            {
                return RedirectToAction("Index", "Home", new { area = "Administrador" });
            }
            return View();
        }

        public IActionResult Olvidaste()
        {
            return View();
        }


    }
}
