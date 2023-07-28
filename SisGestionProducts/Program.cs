using System;
using InfoProducto;

class Program
{

    static Dictionary<int, Producto> Productos = new Dictionary<int, Producto>();

    static void Main() {

        bool continuar = true;

        do {
                Console.Clear();
                Console.WriteLine(" GESTIÓN DE USUARIOS \n\n");
                Console.WriteLine("1. Agregar un Producto");
                Console.WriteLine("2. Mostrar Producto");
                Console.WriteLine("3. Listar todos los Productos");
                Console.WriteLine("4. Actualizar Precios");
                Console.WriteLine("5. Actualizar Cantidad");
                Console.WriteLine("6. Actualizar Clientes");
                Console.WriteLine("7. Terminar\n\n");
                Console.WriteLine("******************************");
                Console.Write("Elija una Opción: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            agregarProducto();
                            break;
                        case 2:
                            mostrarDetalles();
                            break;
                        case 3:
                            mostrarLista();
                            break;
                        case 4:
                            actualizarPrecio();
                            break;
                        case 5:
                            actualizarCantidad();
                            break;
                        case 6:
                            actualizarListado();
                            break;
                        case 7:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Elija Opción entre 1 y 7");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                    Console.ReadKey();
                }
            } while (continuar);
        }

    static void agregarProducto(){
        Console.Clear();
            Console.WriteLine("Agregar Usuario");
            Console.Write("Ingrese ID de Usuario: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (Productos.ContainsKey(id))
                {
                    Console.WriteLine("Número de ID ya existe...");
                }
                else
                {
                    Console.Write("Ingrese nombre del Producto: ");
                    string Nombre =  Console.ReadLine() ?? "";

                    Console.Write("Ingrese el Precio del Producto: ");
                    if (int.TryParse(Console.ReadLine(), out int Precio))
                    {
                        Console.Write("Ingrese el Numero del cantidad del producto: ");
                        if(int.TryParse(Console.ReadLine(), out int inventario)){

                        Console.Write("Ingrese los clientes (separados por comas): ");
                        List<string> Clientes = new List<string>(Console.ReadLine().Split(','));


                        Producto newProducto = new Producto(Nombre, Precio, inventario, Clientes);
                        Productos.Add(id, newProducto);
                        Console.WriteLine("Producto agregado correctamente.");
                        Console.ReadKey();
                        }
                        else {
                            Console.WriteLine("Ingrese un valor numérico para el inventario");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor numérico para la edad");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Número de identificación No válido");
                Console.ReadKey();
            }
    }

    static void mostrarDetalles() {
        Console.Clear();
            Console.WriteLine("Mostrar Producto");
            Console.Write("Ingrese número de identificación del Producto: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (Productos.TryGetValue(id, out Producto Producto))
                {
                    Console.WriteLine("Información del usuario:");
                    Console.WriteLine($"Nombre: {Producto.Nombre}");
                    Console.WriteLine($"Precio: {Producto.Precio}");
                    Console.WriteLine($"Inventario: {Producto.Inventario}");
                    Console.WriteLine("Clientes:");
                    foreach (var cliente in Producto.Clientes)
                    {
                        Console.WriteLine($"- {cliente}");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró un usuario con ese número de identificación.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Número de identificación NO válido.");
                Console.ReadKey();
            }
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
    }

    static void mostrarLista() {
        Console.Clear();
            Console.WriteLine("Listado de Productos ");
            if (Productos.Count > 0)
            {
                foreach (var produc in Productos)
                {
                    Console.WriteLine($"Número de identificación: {produc.Key}");
                    Console.WriteLine($"Nombre: {produc.Value.Nombre}");
                    Console.WriteLine($"Precio: {produc.Value.Precio}");
                    Console.WriteLine($"Cantidad: {produc.Value.Inventario}");
                    Console.WriteLine("Clientes:");
                    foreach (var cliente in produc.Value.Clientes)
                    {
                        Console.WriteLine($"- {cliente}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No hay usuarios registrados.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
    }

    static void actualizarPrecio()
{
    Console.Clear();
    Console.WriteLine("Actualizar Precio de Producto");
    Console.Write("Ingrese número de identificación del Producto a modificar: ");
    
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        if (Productos.ContainsKey(id))
        {
            Console.Write($"El precio actual del producto {Productos[id].Nombre} es: {Productos[id].Precio}");
            Console.Write("\nIngrese el nuevo precio: ");
            
            if (int.TryParse(Console.ReadLine(), out int newPrecio))
            {
                Productos[id].Precio = newPrecio;
            }
            else
            {
                Console.WriteLine("Error: El nuevo precio ingresado no es válido.");
            }
        }
        else
        {
            Console.WriteLine("Error: El ID del producto ingresado no existe en el diccionario.");
        }
    }
    else
    {
        Console.WriteLine("Error: El ID ingresado no es válido.");
    }

    Console.WriteLine($"El nuevo precio del producto se agregado correctamente");
    Console.ReadKey();
}


    static void actualizarCantidad() {
        Console.Clear();
    Console.WriteLine("Actualizar Precio de Producto");
    Console.Write("Ingrese número de identificación del Producto a modificar: ");
    
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        if (Productos.ContainsKey(id))
        {
            Console.Write($"El cantidad actual del producto {Productos[id].Nombre} es: {Productos[id].Inventario}");
            Console.Write("\nIngrese el nuevo precio: ");
            
            if (int.TryParse(Console.ReadLine(), out int newCantidad))
            {
                Productos[id].Inventario = newCantidad;
            }
            else
            {
                Console.WriteLine("Error: la nueva cantidad ingresada no es válido.");
            }
        }
        else
        {
            Console.WriteLine("Error: El ID del producto ingresado no existe en el diccionario.");
        }
    }
    else
    {
        Console.WriteLine("Error: El ID ingresado no es válido.");
    }

    Console.WriteLine($"La nueva cantidad del producto se agregado correctamente");
    Console.ReadKey();
    }

    static void actualizarListado(){
        Console.Clear();
    Console.WriteLine("Actualizar Precio de Producto");
    Console.Write("Ingrese número de identificación del Producto a modificar: ");
    
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        if (Productos.ContainsKey(id))
        {
            Console.Write($"El cantidad actual del producto {Productos[id].Nombre}");

            foreach (var produc in Productos)
                {

                    foreach (var cliente in produc.Value.Clientes)
                    {
                        Console.WriteLine($"- {cliente}");
                    }
                    Console.WriteLine();
                }

            Console.Write("\nIngrese los nuevo clientes: ");

            Console.Write("Ingrese los clientes (separados por comas): ");
            List<string> Clientes = new List<string>(Console.ReadLine().Split(','));

            Productos[id].Clientes = Clientes;
            
        }
        else
        {
            Console.WriteLine("Error: El ID del producto ingresado no existe en el diccionario.");
        }
    }
    else
    {
        Console.WriteLine("Error: El ID ingresado no es válido.");
    }

    Console.WriteLine($"La nueva cantidad del producto se agregado correctamente");
    Console.ReadKey();
    }
    }

