using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.Postulante.Controllers
{
    [Area("Postulante")]
    public class Perfil : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
    }
}
