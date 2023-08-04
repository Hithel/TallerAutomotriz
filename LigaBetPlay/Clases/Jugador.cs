namespace LigaBetPlay.Clases;

public class Jugador : Persona
{
    public int dorsal { get; set; }
    public string posicion { get; set; }
    public int nivelHabilidad { get; set; }

    public Jugador(string nombre, int id, DateTime fechaNacimiento, string ciudadOrigen, int dorsal, string posicion, int nivelHabilidad) : base(nombre, id, fechaNacimiento, ciudadOrigen)
    {
        this.dorsal = dorsal;
        this.posicion = posicion;
        this.nivelHabilidad = nivelHabilidad;
    }

    public Jugador():  base("", 0, DateTime.Now, "")
    {
    }

    public Jugador CrearJugador(Persona persona){
        
        Jugador jugador = new (persona.nombre, persona.id, persona.fechaNacimiento, persona.ciudadOrigen, 0,"",0);

        Console.WriteLine("Ingrese el dorsal del jugador");
        jugador.dorsal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la posicion del jugador");
        jugador.posicion = Console.ReadLine()!;

        Console.WriteLine("Ingrese el nivel de habilidad jugador");
        jugador.nivelHabilidad = Convert.ToInt32(Console.ReadLine());

        return jugador;
    }

    public void MostrarJugadores(Equipo EquipoSelecionado){
        Console.Clear();

        Console.WriteLine("ID\t Nombre\t Fecha Nacimiento\t Cuidad Origen\t Dorsal\t Posicion\t Nivel de Habilidad");

            foreach(var jugador in EquipoSelecionado.jugadores){
                Console.WriteLine($"{jugador.id}\t {jugador.nombre}\t {jugador.fechaNacimiento}\t {jugador.ciudadOrigen}\t {jugador.dorsal}\t {jugador.posicion}\t\t {jugador.nivelHabilidad}");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
    }
}
