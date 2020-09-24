using Entidades;
using ModuloFacturacion;
using System;

namespace Servicios
{
    public class BalanceServicio
    {
        public BalanceServicio()
        {
        }

        public BalanceMes ObtenerBalanceMes(int mes)
        {
            var facturacionAntiguo = new FacturacionAntiguo();
            //var facturacionAntiguo = new FacturacionNuevo();

            return facturacionAntiguo.ObtenerBalanceDelMes(mes);
        }
      
    }
}