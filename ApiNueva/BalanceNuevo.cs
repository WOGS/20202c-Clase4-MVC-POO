namespace ApiNueva
{
    public class BalanceNuevo
    {
        public double Ingresos { get; set; }
        public double Egresos { get; set; }


        public static BalanceNuevo ObtenerEjemplo()
        {
            var balance = new BalanceNuevo();
            balance.Ingresos = 10000;
            balance.Egresos = 5000;
          
            return balance;
        }
    }
}