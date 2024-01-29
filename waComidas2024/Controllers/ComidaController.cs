using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waComidas2024.Models;

namespace waComidas2024.Controllers
{
    public class ComidaController : Controller
    {
        // GET: Comida
        public ActionResult Crear(Comidas obj)
        {
            DaoComidas dao = new DaoComidas();
            string msj = dao.insertar(obj);
            ViewBag.mensaje = msj;
            ViewBag.com = obj.comcom;
            return View();
        }
    }
}