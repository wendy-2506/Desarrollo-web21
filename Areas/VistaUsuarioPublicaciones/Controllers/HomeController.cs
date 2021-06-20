using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.VistaUsuarioPublicaciones.Controllers
{
    [Area("VistaUsuarioPublicaciones")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
