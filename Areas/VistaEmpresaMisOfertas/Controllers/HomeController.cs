using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.VistaEmpresaMisOfertas.Controllers
{
    [Area("VistaEmpresaMisOfertas")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
