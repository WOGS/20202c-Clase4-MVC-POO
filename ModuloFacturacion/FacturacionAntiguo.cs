using ApiAntigua;
using ApiNueva;
using Entidades;
using System;

namespace ModuloFacturacion
{
    public class FacturacionAntiguo : IFacturacion
    {
        string APIUsuario = "";
        string APIPassword = "";
        public FacturacionAntiguo()
        {
            APIUsuario = System.Configuration.ConfigurationManager.AppSettings["API_Usuario"];
            APIPassword = System.Configuration.ConfigurationManager.AppSettings["API_Password"];
        }

        public BalanceMes ObtenerBalanceDelMes(int mes)
        {
            BalanceMes balanceMes = new BalanceMes();

            ApiSistemaFacturacionAntiguo api = new ApiSistemaFacturacionAntiguo();
            string token = api.ObtenerTokenLogin(APIUsuario, APIPassword);
            BalanceAntiguo balanceAntiguo = api.ObtenerBalance(token, mes);

            balanceMes.Gastos = balanceAntiguo.GastosMantenimiento + balanceAntiguo.Impuestos;
            balanceMes.Ingresos = balanceAntiguo.IngresosLicencias + balanceAntiguo.Ventas;
            balanceMes.NombreMes = new DateTime(2020, mes, 1).ToString("MMMM");

            return balanceMes;
        }

    }
}