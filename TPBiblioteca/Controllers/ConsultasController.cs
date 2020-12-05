using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPBiblioteca.Models;

namespace TPBiblioteca.Controllers
{
    public class ConsultasController : Controller
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: Consultas
        public ActionResult Index()
        {
            return View();
        }
    }
}