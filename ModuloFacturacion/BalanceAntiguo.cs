namespace ModuloFacturacion
{
    public class BalanceAntiguo
    {
        public double IngresosLicencias { get; set; }
        public double Impuestos { get; set; }
        public double GastosMantenimiento { get; set; }
        public double Ventas { get; set; }


        public static BalanceAntiguo ObtenerEjemplo()
        {
            var balanceAntiguo = new BalanceAntiguo();
            balanceAntiguo.GastosMantenimiento = 10000;
            balanceAntiguo.Impuestos = 5000;
            balanceAntiguo.IngresosLicencias = 2000;
            balanceAntiguo.Ventas = 15000;

            return balanceAntiguo;
        }
    }
}