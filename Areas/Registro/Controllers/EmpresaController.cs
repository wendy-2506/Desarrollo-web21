﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Areas.Registro.Controllers
{
    [Area("Registro")]
    public class EmpresaController : Controller
    {
        public IActionResult RegistroEmpresa()
        {
            return View();
        }
    }
}
