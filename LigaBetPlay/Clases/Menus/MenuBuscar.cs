namespace LigaBetPlay.Clases.Menus;

    public class MenuBuscar
    {
        public void EjecutarMenuBuscar(){
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
