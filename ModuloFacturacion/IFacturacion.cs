using Entidades;

namespace ModuloFacturacion
{
    public interface IFacturacion
    {
        BalanceMes ObtenerBalanceDelMes(int mes);
    }
}