using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waComidas2024.Models;

namespace waComidas2024.Controllers
{
    public class ComidasController : Controller
    {
        // GET: Comidas
        public ActionResult Index()
        {
            IEnumerable<Comidas> listado = new List<Comidas>();
            DaoComida dao = new DaoComida();
            listado = dao.listar();
            return View(listado);
        }
    }
}