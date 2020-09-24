using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAntigua
{
    public class ApiSistemaFacturacionAntiguo
    {
        const string TOKEN_VALIDO = "ABC123";
        public string ObtenerTokenLogin(string usuario, string password)
        {
            return TOKEN_VALIDO;
        }

        public BalanceAntiguo ObtenerBalance(string token, int mes)
        {
            if (token != TOKEN_VALIDO)
                throw new UnauthorizedAccessException("Token invalido");
            BalanceAntiguo balance = BalanceAntiguo.ObtenerEjemplo();

            return balance;
        }

    }
}
