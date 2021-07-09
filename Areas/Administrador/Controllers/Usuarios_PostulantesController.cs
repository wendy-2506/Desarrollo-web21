using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class Usuarios_PostulantesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
