using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase_4_MVC_POO.Controllers
{
    public class GastosController : Controller
    {

        public ActionResult Index()
        {
            List<Gasto> gastos = GastosServicios.ObtenerTodos();

            return View(gastos);
        }
        // GET: Gastos
        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Gasto gasto)
        {
            GastosServicios.Alta(gasto);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(Guid id)
        {
            Gasto gasto = GastosServicios.ObtenerPorId(id);

            return View(gasto);
        }

        [HttpPost]
        public ActionResult Editar(Gasto gasto)
        {
            //TODO: Agregar modificar
            //GastosServicios.Modificar(gasto);
            return RedirectToAction("Index");
        }
    }
}