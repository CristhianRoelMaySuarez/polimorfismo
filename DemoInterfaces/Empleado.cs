namespace DemoInterfaces
{
    public class Empleado : Persona, IASalariable
    {
        public string Rfc { get; set; }
        public DateTime FechaDeIngreso { get; set; }

        public Empleado(string nombre, string apellidos, string rfc, DateTime fechaDeIngreso, decimal v) : base(nombre, apellidos)
        {
            Rfc = rfc;
            FechaDeIngreso = fechaDeIngreso;
        }

        public decimal CalcularSalario()
        {
            return decimal.Zero;
        }

    }

}

