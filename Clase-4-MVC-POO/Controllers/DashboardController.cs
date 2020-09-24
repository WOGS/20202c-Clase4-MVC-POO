using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase_4_MVC_POO.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult BalanceMes(int id)
        {
            var balanceServicio = new BalanceServicio();
            BalanceMes balanceMes = balanceServicio.ObtenerBalanceMes(id);

            return View(balanceMes);
        }
    }
}