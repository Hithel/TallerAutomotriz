
namespace TallerAutomotriz.Entities;
public class Cliente : Persona
{
    public DateTime FechaRegistro { get; set; }

    public List<Vehiculos> listaVehiculos = new List<Vehiculos>();


    public Cliente(int Id, string Nombre, string Apellidos, int Celular, string Email, DateTime FechaRegistro) : base(Id, Nombre, Apellidos, Celular, Email)
    {
        this.FechaRegistro = FechaRegistro;
        this.listaVehiculos = new List<Vehiculos>();
    }

    public Cliente() : base()
    {
        this.listaVehiculos = new List<Vehiculos>();
    }

    public Cliente CrearCliente()
    {
        Console.Clear();

        Cliente cliente = new Cliente();

        Console.WriteLine("Ingrese la Cedula de la cliente");
        cliente.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el Nombre de la cliente");
        cliente.Nombre = Console.ReadLine()!;

        Console.WriteLine("Ingrese los apellidos de la cliente");
        cliente.Apellidos = Console.ReadLine()!;

        Console.WriteLine("Ingrese el celular de la cliente");
        cliente.Celular = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el correo de la cliente");
        cliente.Email = Console.ReadLine();

        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Ingrese la fecha de registro en dd/mm/yyyy");
            string fechaRegis = Console.ReadLine()!;

            if (DateTime.TryParseExact(fechaRegis, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime FechaRegistro))
            {
                cliente.FechaRegistro = FechaRegistro.Date;
                valid = true;

            }
            else
            {
                Console.WriteLine("El formato de fecha ingresado es inválido.");
            }
        }
        Console.WriteLine("\n Se ha agregado correctamente");
        Console.WriteLine("\nToca enter para continuar");
        Console.ReadKey();

        return cliente;



    }

    public void MostrarClientes(List<Cliente> listaClientes)
    {
        Console.Clear();

        Console.WriteLine("ID\t Nombre\t Apellidos\t Celular\t Email\t FechaRegistro");

        foreach (var cliente in listaClientes)
        {
            Console.WriteLine($"{cliente.Id}\t {cliente.Nombre}\t {cliente.Apellidos}\t {cliente.Celular}\t {cliente.Email}\t {cliente.FechaRegistro}");

        }
        Console.WriteLine("\nToca enter para continuar");
        Console.ReadKey();
    }

    public Cliente BuscarCliente(List<Cliente> listaClientes)
    {

        MostrarClientes(listaClientes);

        Console.WriteLine("Ingrese el ID del Cliente");
        int opcion = int.Parse(Console.ReadLine()!);

        return listaClientes.Find(n => n.Id == opcion)!;

    }

}
