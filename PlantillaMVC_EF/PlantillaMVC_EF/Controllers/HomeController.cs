using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlantillaMVC_EF.Models.Manager;

namespace PlantillaMVC_EF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Catalogo de Alumnos";
            ViewBag.Datos = AlumnoManager.ListarContenido();
            return View();
        }
        public ActionResult verAlumno(int id)
        {
            ViewBag.Title = "Ficha del Alumno";
            ViewBag.Dato = AlumnoManager.getById(id);
            return View();
        }

    }
}