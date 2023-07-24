using System;

class Program {
    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    Saludar();
                    break;
                case 2:
                    CalcularCuadrado();
                    break;
                case 3:
                    CalcularCirculo();
                    break;
                case 4:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 4);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Saludar");
        Console.WriteLine("2. Calcular el cuadrado de un número");
        Console.WriteLine("3. Calcular el área de un círculo");
        Console.WriteLine("4. Salir");
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Saludar() {
        Console.WriteLine("¡Hola! ¡Bienvenido!");
    }

    static void CalcularCuadrado() {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int cuadrado = numero * numero;
        Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
    }

    static void CalcularCirculo() {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radio * radio;
        Console.WriteLine($"El área del círculo es: {area}");
    }
}