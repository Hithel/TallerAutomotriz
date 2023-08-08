namespace TallerAutomotriz.Entities;

public class Vehiculos
{
    public int Id { get; set; }
    public string Placa { get; set; }
    public int Modelo { get; set; }
    public string Marca { get; set; }
    public string Color { get; set; }
    public float Km { get; set; }

    public Vehiculos(int Id, string Placa, int Modelo, string Marca, string Color, float Km)
    {
        this.Id = Id;
        this.Placa = Placa;
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Color = Color;
        this.Km = Km;
    }

    public Vehiculos() { }

    public Vehiculos CrearVechiculo()
    {
        Console.Clear();

        Vehiculos vehiculo = new Vehiculos();

        Console.WriteLine("Ingrese el ID del Vehiculo");
        vehiculo.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la Placa del Vehiculo");
        vehiculo.Placa = Console.ReadLine()!;

        Console.WriteLine("Ingrese el modelo del Vehiculo");
        vehiculo.Modelo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el marca del Vehiculo");
        vehiculo.Marca = Console.ReadLine()!;

        Console.WriteLine("Ingrese el Color del Vehiculo");
        vehiculo.Color = Console.ReadLine()!;

        Console.WriteLine("Ingrese el kilometraje del Vehiculo");
        vehiculo.Km = float.Parse(Console.ReadLine()!);

        return vehiculo;
    }

    public void MostrarVehiculos(Cliente selecionarCliente)
    {
        Console.Clear();

        Console.WriteLine("ID\t Placa\t Modelo\t Marca\t Color\t Km");

        foreach (var vehiculos in selecionarCliente.listaVehiculos)
        {
            Console.WriteLine($"{vehiculos.Id}\t{vehiculos.Placa}\t {vehiculos.Modelo} \t {vehiculos.Marca}\t {vehiculos.Color}\t {vehiculos.Km}\t");

        }
        Console.WriteLine("\nToca enter para continuar");
        Console.ReadKey();
    }

    public Vehiculos BuscarVehiculos(Cliente seleccionarCliente){

        MostrarVehiculos(seleccionarCliente);

        Console.WriteLine("Ingrese el ID del Equipo");
        int opcion = int.Parse(Console.ReadLine()!);

        return seleccionarCliente.listaVehiculos.Find(n => n.Id == opcion)!;
    }

}
