using LigaBetPlay.Clases;

namespace LigaBetPlay.Clases.Menus;
public class MenuPlantel
{
    public void EjecutarMenuPlantel(List<Ligas> listLigas)
    {
        bool validacion = true;

        do
        {

            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTIÓN DE LIGA\n\n");
            Console.WriteLine("1. Registro Equipo");
            Console.WriteLine("2. Registro de Jugador");
            Console.WriteLine("3. Registro de Entrenador");
            Console.WriteLine("4. Registro de Masajista");
            Console.WriteLine("5. Registro de Venta Jugador");
            Console.WriteLine("6. Regresar al Menu Principal\n");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Ligas buscarLiga = new Ligas()!;
                Equipo equipo = new Equipo()!;
                Persona persona = new Persona()!;
                

                switch (opcion)
                {
                    case 1:
                        Ligas LigaSelecionada = buscarLiga.BuscarLigas(listLigas);
                        
                        Equipo newEquipo = equipo.AgregarEquipo();
                        Console.WriteLine($"El ID del nuevo equipo es: {newEquipo.id}");
                        Console.WriteLine($"El nombre del nuevo equipo es: {newEquipo.nombre}");
                        
                        LigaSelecionada.equiposLigas.Add(newEquipo);
                        Console.WriteLine($"El equipo : {newEquipo.nombre} se a agregado correctamente");
                        newEquipo.MostrarEquipo(LigaSelecionada);
                        Console.ReadKey();

                        break;
                    case 2:
                        Ligas LigaSelect = buscarLiga.BuscarLigas(listLigas);
                        Equipo EquipoSelecionado = equipo.BuscarEquipo(LigaSelect);
                        Persona newPersona = persona.CrearPersona();
                        Jugador jugador = new Jugador()!;
                        Jugador newJugador = jugador.CrearJugador(newPersona);
                        EquipoSelecionado.jugadores.Add(newJugador);
                        newJugador.MostrarJugadores(EquipoSelecionado);
                        Console.WriteLine("\nToca enter para continuar.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Ligas ligasSeleccionada = buscarLiga.BuscarLigas(listLigas);
                        Equipo equipoSeleccionado = equipo.BuscarEquipo(ligasSeleccionada);
                        Persona NewPersona = persona.CrearPersona();
                        Entrenador entrenador = new Entrenador()!;
                        Entrenador newEntrenador = entrenador.CrearEntrenador(NewPersona);
                        equipoSeleccionado.entrenadores.Add(newEntrenador);
                        newEntrenador.MostrarEntrenador(equipoSeleccionado);
                        Console.WriteLine("\nToca enter para continuar.");
                        Console.ReadKey();

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
            else
            {
                Console.WriteLine("Ingrese una opción valida: ");
                Console.ReadKey();
            }
        }
        while (validacion);
    }
}