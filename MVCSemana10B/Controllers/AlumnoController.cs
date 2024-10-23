using MVCSemana10B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSemana10B.Controllers
{
    public class AlumnoController : Controller
    {
        List<Alumno> alumnos = new List<Alumno>();
        // GET: Alumno
        public ActionResult Index()
        {

            if (Session["alumnos"] == null)
            {
                Session["alumnos"] = alumnos;
            }
            else
            {
                alumnos = (List<Alumno>)Session["alumnos"];
            }

            return View(alumnos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            ((List<Alumno>)Session["alumnos"]).Add(alumno);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            alumnos = (List<Alumno>)Session["alumnos"];
            Alumno alumno = alumnos.FirstOrDefault(a => a.AlumnoID == id);
            if (alumno == null)
            {
                return HttpNotFound();
            }

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Edit(Alumno updatedAlumno)
        {
            alumnos = (List<Alumno>)Session["alumnos"];
            Alumno alumno = alumnos.FirstOrDefault(a => a.AlumnoID == updatedAlumno.AlumnoID);
            if (alumno != null)
            {
                alumno.Nombre = updatedAlumno.Nombre;
                alumno.Edad = updatedAlumno.Edad;
                alumno.Sexo = updatedAlumno.Sexo;
            }

            Session["alumnos"] = alumnos;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
    }
}