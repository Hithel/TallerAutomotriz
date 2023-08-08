namespace TallerAutomotriz.Entities
{
    public class Empleados : Persona
    {

        public string? Especialidad { get; set; }

        public string? Ocupabilidad { get; set; }

        public Empleados(int Id, string Nombre, string Apellidos, int Celular, string Email, string Especialidad, string Ocupabilidad) : base(Id, Nombre, Apellidos, Celular, Email)
        {
            this.Especialidad = Especialidad;
            this.Ocupabilidad = Ocupabilidad;
        }

        public Empleados() : base() { }


        public Empleados CrearEmpleado()
        {
            Console.Clear();

            Empleados empleado = new Empleados();

            Console.WriteLine("Ingrese la Cedula del empleado");
            empleado.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del empleado");
            empleado.Nombre = Console.ReadLine()!;

            Console.WriteLine("Ingrese los apellidos del empleado");
            empleado.Apellidos = Console.ReadLine()!;

            Console.WriteLine("Ingrese el celular del empleado");
            empleado.Celular = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el correo del empleado");
            empleado.Email = Console.ReadLine();

            Console.WriteLine("Ingrese la especialidad del empleado");
            empleado.Especialidad = Console.ReadLine()!;

            Console.WriteLine("Ingrese la ocupabilidad del empleado");
            empleado.Ocupabilidad = Console.ReadLine()!;

            return empleado;
        }

        public void MostrarEmpleados(List<Empleados> listaEmpleado)
        {
            Console.Clear();

            Console.WriteLine("ID\t Nombre\t Apellidos\t Celular\t Email\t Especialidad \t Ocupabilidad");

            foreach (var empleado in listaEmpleado)
            {
                Console.WriteLine($"{empleado.Id}\t {empleado.Nombre}\t {empleado.Apellidos}\t {empleado.Celular}\t {empleado.Email}\t {empleado.Especialidad}\t {empleado.Ocupabilidad} ");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
        }

        public Empleados BuscarEmpleado(List<Empleados> listaEmpleado)
        {

            MostrarEmpleados(listaEmpleado);

            Console.WriteLine("Ingrese el ID del Equipo");
            int opcion = int.Parse(Console.ReadLine()!);

            return listaEmpleado.Find(n => n.Id == opcion)!;

        }
    }
}