using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waComidas2024.Models;

namespace waComidas2024.Controllers
{
    public class BusquedaController : Controller
    {
        // GET: Busqueda
        public ActionResult ConsultaDIA(Comidas obj)
        {
            IEnumerable<Comidas> lista = new List<Comidas>();
            DaoBusqueda dao = new DaoBusqueda();
            ViewBag.day = obj.diacom;
            lista = dao.consultar(obj);
            return View(lista);
        }
    }
}