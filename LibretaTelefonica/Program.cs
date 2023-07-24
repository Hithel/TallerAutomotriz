internal partial class Program
{

    static List<(string, int, bool)> Entradas = new List<(string, int, bool)>();

    static void Main(string[] args)
    {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    agregarEntrada();
                    break;
                case 2:
                    mostrarEntradas();
                    break;
                case 3:
                    marcarImportante();
                    break;
                case 4:
                    eliminarEntradas();
                    break;
                case 5:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Agregar Entrada");
        Console.WriteLine("2. Mostrar Entradas");
        Console.WriteLine("3. Marcar Importante");
        Console.WriteLine("4. Eliminar Entradas");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void agregarEntrada() {
        Console.WriteLine("Ingrese el nombre:");
        string ? nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el Numero");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool favorito = false;

        Entradas.Add((nombre, numero, favorito));
    }

    static void mostrarEntradas() {
        // foreach (var entrada in Entradas) {
        //     Console.WriteLine($"Nombre de la entradas: {entrada.Item1}");
        //     Console.WriteLine($"Numero de la entradas: {entrada.Item2}");
        //     Console.WriteLine($"Importante: {entrada.Item3}");
        // }

        for (int i = 0; i < Entradas.Count; i++){

            var entrada = Entradas[i];

            Console.WriteLine($"Índice: {i}");
            Console.WriteLine($"Nombre de la entrada: {entrada.Item1}");
            Console.WriteLine($"Número de la entrada: {entrada.Item2}");
            Console.WriteLine($"Importante: {entrada.Item3}");
        }
    }

    static void marcarImportante() {

        Console.Write("Ingrese el Indice: ");
        int indice = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < Entradas.Count; i++){
            if(i == indice){
                var entrada = Entradas[i];
                var entradaModificada = (entrada.Item1, entrada.Item2, true);
                Entradas[i] = entradaModificada;
                Console.WriteLine($"La entrada ha sido marcada como importante");
            }
        }
    }

    static void eliminarEntradas() {
        Console.Write("Ingrese el Indice: ");
        int indice = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < Entradas.Count; i++){
            if(i == indice){
                Entradas.RemoveAt(indice);
            }
        }
    }
}