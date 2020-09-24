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
            //IFacturacion facturacion = new FacturacionAntiguo();
            IFacturacion facturacion = new FacturacionNuevo();

            return facturacion.ObtenerBalanceDelMes(mes);
        }
      
    }
}