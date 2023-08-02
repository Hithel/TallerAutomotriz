using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MenuPrincipal();
    }

    static void MenuPrincipal(){

        bool validacion = true;

        do{
            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTIÓN DE LIGA\n\n");
            Console.WriteLine("1. Registro Plantel");
            Console.WriteLine("2. Consultar Datos");
            Console.WriteLine("3. Salir\n");
            Console.Write("Seleccione una opción: ");

            if(int.TryParse(Console.ReadLine(), out int opcion)){
                switch(opcion){
                    case 1:
                        MenuRegistroPanel();
                        break;
                    case 2: 
                        MenuConsultaDatos();
                        break;
                    case 3:
                        validacion = false;
                        break;
                    default: 
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                }
            }
            else {
                Console.WriteLine("Ingrese una opción valida: ");
                Console.ReadKey();
            }
        }
        while (validacion);
    }

    static void MenuRegistroPanel(){

        bool validacion = true;
        
        do{

            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTIÓN DE LIGA\n\n");
            Console.WriteLine("1. Registro Equipo");
            Console.WriteLine("2. Registro de Jugador");
            Console.WriteLine("3. Registro de Entrenador");
            Console.WriteLine("4. Registro de Masajista");
            Console.WriteLine("5. Registro de Venta Jugador");
            Console.WriteLine("6. Regresar al Menu Principal\n");
            Console.Write("Seleccione una opción: ");

            if(int.TryParse(Console.ReadLine(), out int opcion)){
            switch(opcion){
                case 1:
                    Console.WriteLine("Registro Equipo");
                    break;
                case 2:
                    Console.WriteLine("Registro de Jugador");
                    break;
                case 3:
                    Console.WriteLine("Registro de Entrenador");
                    break;
                case 4:
                    Console.WriteLine("Registro de Masajista");
                    break;
                case 5:
                    Console.WriteLine("Registro de Venta Jugador");
                    break;
                case 6:
                    Console.WriteLine("Regresar al Menu Principal");
                    validacion = false;
                    break;
                default: 
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;
            }
        }
        else {
            Console.WriteLine("Ingrese una opción valida: ");
            Console.ReadKey();
        }
        }
        while(validacion);
    }

    static void MenuConsultaDatos(){

        bool validacion = true;
        
        do{

            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTIÓN DE LIGA\n\n");
            Console.WriteLine("1. Listar Jugadores por Equipo");
            Console.WriteLine("2. Buscar Delanteros en cada Equipo");
            Console.WriteLine("3. Buscar Entrenadores por Equipo");
            Console.WriteLine("4. Regresar al Menu Principal\n");
            Console.Write("Seleccione una opción: ");

            if(int.TryParse(Console.ReadLine(), out int opcion)){
            switch(opcion){
                case 1:
                    Console.WriteLine("Registro Equipo");
                    break;
                case 2:
                    Console.WriteLine("Registro de Jugador");
                    break;
                case 3:
                    Console.WriteLine("Registro de Entrenador");
                    break;
                case 4:
                    Console.WriteLine("Regresar al Menu Principal");
                    validacion = false;
                    break;
                default: 
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;
            }
        }
        else {
            Console.WriteLine("Ingrese una opción valida: ");
            Console.ReadKey();
        }

        }
        while(validacion);
    }
}