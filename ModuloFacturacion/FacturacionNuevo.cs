using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacion
{
    public class FacturacionNuevo
    {
        public BalanceMes ObtenerBalanceDelMes(int mes)
        {
            BalanceMes balanceMes = new BalanceMes();
            return BalanceMes.ObtenerEjemplo();
            //ir a buscar balance de api, bd o csv en ftp
        }
    }
}
