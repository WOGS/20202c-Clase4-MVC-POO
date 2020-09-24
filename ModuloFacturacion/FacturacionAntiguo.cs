using Entidades;
using System;

namespace ModuloFacturacion
{
    public class FacturacionAntiguo
    {
        public FacturacionAntiguo()
        {
        }

        public BalanceMes ObtenerBalanceDelMes(int mes)
        {
            BalanceMes balanceMes = new BalanceMes();
            return BalanceMes.ObtenerEjemplo();

            //ir a buscar balance de api, bd o csv en ftp
        }

    }
}