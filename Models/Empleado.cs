namespace EFCRUD8.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public DateOnly FechaContrato { get; set; }

        public bool Activo { get; set; }

    }
}
