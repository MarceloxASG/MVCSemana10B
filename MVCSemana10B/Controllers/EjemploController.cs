using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSemana10B.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatosPersomales()
        {
            return View();
        }

        public ActionResult Direccion()
        {
            return View();
        }
    }
}