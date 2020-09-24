using ApiNueva;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacion
{
    public class FacturacionNuevo : IFacturacion
    {
        public BalanceMes ObtenerBalanceDelMes(int mes)
        {
            BalanceMes balanceMes = new BalanceMes();

            ApiSistemaFacturacionNuevo api = new ApiSistemaFacturacionNuevo();
            BalanceNuevo balanceNuevo = api.ObtenerBalance(mes);

            balanceMes.Gastos = balanceNuevo.Egresos;
            balanceMes.Ingresos = balanceNuevo.Ingresos;
            balanceMes.NombreMes = new DateTime(2020, mes, 1).ToString("MMMM");

            return balanceMes;
        }
    }
}
