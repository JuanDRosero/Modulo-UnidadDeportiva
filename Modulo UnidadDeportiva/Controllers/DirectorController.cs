﻿using Microsoft.AspNetCore.Mvc;
using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IReportes _reportes;
        private Empleado _empleado;
        public DirectorController(IReportes reportes)
        {
            _reportes = reportes;
        }

        public IActionResult Index(Empleado? empleado)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 2)
            {
                return RedirectToAction("Index", "Home");
            }
            _empleado = empleado;
            return View(empleado);
        }

        [Route("/HorasPasantes")]
        [HttpGet]
        public IActionResult HorasPasante()  //Redireccionar
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Route("/HorasEquipo")]
        [HttpGet]
        public IActionResult HorasEquipo() //Corregir este metodo para que redireccione
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
