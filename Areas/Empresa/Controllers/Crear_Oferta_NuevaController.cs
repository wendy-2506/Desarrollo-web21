using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.Empresa.Controllers
{
    [Area("Empresa")]
    public class Crear_Oferta_NuevaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
