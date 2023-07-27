using System;
using Productos;
using Diccionario;

class Program
{

    static Dictionary<int, Usuario> Usuarios = new Dictionary<int, Usuario>();

    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            Console.Write($"Opcion");

            // switch (opcion) {
            //     case 1:
            //         agregarProducto();
            //         break;
            //     case 2:
            //         mostrarDetalles();
            //         break;
            //     case 3:
            //         mostrarLista();
            //         break;
            //     case 4:
            //         actualizarPrecio();
            //         break;
            //     case 5:
            //         actualizarCantidad();
            //         break;
            //     case 6:
            //         actualizarListado();
            //         break;
            //     case 7:
            //         Console.WriteLine("Hasta luego.");
            //         break;

            //     default:
            //         Console.WriteLine("\nOpción inválida. Inténtalo de nuevo.");
            //         break;
            // }

            Console.WriteLine();
        } while (opcion != 7);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones: \n1. Agregar un nuevo producto \n2. Mostrar los detalles de un producto \n3. Mostrar la lista de productos \n4. Actualizar el precio de un producto \n5. Actualizar la cantidad en inventario\n6. Actualizar el listado de clientes.\n7. Salir");
    }

    static int PedirOpcion() {
        Console.Write("Elija una opción: ");
        if (int.TryParse(Console.ReadLine(), out int opcion)) {
            return opcion;
        }
    }
    static void agregarProducto(){

    }

    static void mostrarDetalles() {

    }

    static void mostrarLista() {}

    static void actualizarPrecio() {}

    static void actualizarCantidad() {}

    static void actualizarListado(){}

}
