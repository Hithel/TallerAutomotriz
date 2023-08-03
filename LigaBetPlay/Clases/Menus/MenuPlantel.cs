using LigaBetPlay.Clases;

namespace LigaBetPlay.Clases.Menus;
    public class MenuPlantel
    {
        public void EjecutarMenuPlantel(List<Ligas> listLigas){
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
                    Ligas buscarLiga = new Ligas();
                    Ligas LigaSelecionada = buscarLiga.BuscarLigas(listLigas);
                    Console.WriteLine($" La liga Selecionada es: {LigaSelecionada.Nombre}");
                    Equipo equipo = new Equipo();
                    Equipo newEquipo = equipo.AgregarEquipo();
                    Console.WriteLine($"El nombre del nuevo equipo es: {newEquipo.nombre}");
                    LigaSelecionada.equiposLigas.Add(newEquipo);
                    Console.WriteLine($"El equipo : {LigaSelecionada.equiposLigas[0].nombre} se a agregado correctamente");
                    Console.ReadKey();

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
    }