namespace TallerAutomotriz.Entities;
public class Respuestos
{
    public int id { get; set; }
    public string? Nombre { get; set; }
    public string? Marca { get; set; }
    public float Valor { get; set; }
    public int Cantidad { get; set; }
    public DateTime FechaAgregado { get; set; }


    public Respuestos(int id, string? Nombre, string? Marca, float Valor, int Cantidad, DateTime FechaAgregado)
    {
        this.id = id;
        this.Nombre = Nombre;
        this.Marca = Marca;
        this.Valor = Valor;
        this.Cantidad = Cantidad;
        this.FechaAgregado = FechaAgregado;
    }

    public Respuestos() { }


    public Respuestos CrearRepuesto()
    {

        Console.Clear();

        Respuestos respuesto = new Respuestos();

        Console.WriteLine("Ingrese el codigo del producto");
        respuesto.id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el Nombre del producto");
        respuesto.Nombre = Console.ReadLine()!;

        Console.WriteLine("Ingrese la Marca del producto");
        respuesto.Marca = Console.ReadLine()!;

        Console.WriteLine("Ingrese el valor del Producto");
        respuesto.Valor = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese la cantidad del Producto");
        respuesto.Cantidad = Convert.ToInt32(Console.ReadLine());

        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Ingrese la fecha de registro en dd/mm/yyyy");
            string fechaRegis = Console.ReadLine()!;

            if (DateTime.TryParseExact(fechaRegis, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime FechaRegistro))
            {
                respuesto.FechaAgregado = FechaRegistro.Date;
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


        return respuesto;

    }

    public void MostrarRepuestos( List<Respuestos> listaRespuestos)
        {
            Console.Clear();

            Console.WriteLine("ID\t Nombre\t Marca\t Celular\t Valor\t Cantidad \t FechaAgregado");

            foreach (var respuesto in listaRespuestos)
            {
                Console.WriteLine($"{respuesto.id}\t {respuesto.Nombre}\t {respuesto.Marca}\t {respuesto.Valor}\t {respuesto.Cantidad}\t {respuesto.FechaAgregado}\t ");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
        }
}
