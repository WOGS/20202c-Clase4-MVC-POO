namespace Entidades
{
    public class BalanceMes
    {
        public string NombreMes { get; set; }
        public double Gastos { get; set; }
        public double Ingresos { get; set; }

        public static BalanceMes ObtenerEjemplo()
        {
            var b = new BalanceMes();
            b.Gastos = 200000;
            b.NombreMes = "Diciembre";
            b.Ingresos = 300000;
            return b;
        }
    }
}