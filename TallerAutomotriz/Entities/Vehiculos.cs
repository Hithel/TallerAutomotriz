namespace TallerAutomotriz.Entities;

public class Vehiculos
{
    private string Placa { get; set; }
    private int Modelo { get; set; }
    private string Marca { get; set; }
    private string Color { get; set; }
    private float Km { get; set; }

    public Vehiculos(string Placa, int Modelo, string Marca, string Color, float Km)
    {
        this.Placa = Placa;
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Color = Color;
        this.Km = Km;
    }

    public Vehiculos(){}

    public Vehiculos CrearVechiculo()
    {
        Console.Clear();

        Vehiculos vehiculo = new Vehiculos();

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

    public void MostrarVehiculos(Cliente selecionarCliente){
        Console.Clear();

        Console.WriteLine("Placa\t Modelo\t Marca\t Color\t Km");

            foreach(var vehiculos in selecionarCliente.listaVehiculos){
                Console.WriteLine($"{vehiculos.Placa}\t {vehiculos.Modelo} \t {vehiculos.Marca}\t {vehiculos.Color}\t {vehiculos.Km}\t");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
    }


}
