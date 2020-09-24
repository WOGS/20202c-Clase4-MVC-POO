using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiNueva
{
    public class ApiSistemaFacturacionNuevo
    {
        public BalanceNuevo ObtenerBalance(int mes)
        {
            BalanceNuevo balance = BalanceNuevo.ObtenerEjemplo();

            return balance;
        }

    }
}
