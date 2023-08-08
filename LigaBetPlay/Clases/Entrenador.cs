using LigaBetPlay.Clases;

namespace LigaBetPlay.Clases;

public class Entrenador : Persona
{
    public int codFederacion { get; set; }
    public string especialidad { get; set; }

    public Entrenador(string nombre, int id, DateTime fechaNacimiento, string ciudadOrigen, int codFederacion, string especialidad) : base(nombre, id, fechaNacimiento, ciudadOrigen)
    {
        this.codFederacion = codFederacion;
        this.especialidad = especialidad;
    }

    public Entrenador() : base("", 0, DateTime.Now, "")
    {
    }

    public Entrenador CrearEntrenador(Persona persona){

        Entrenador entrenador = new Entrenador(persona.nombre, persona.id, persona.fechaNacimiento, persona.ciudadOrigen, 0,"");

        Console.WriteLine("Ingrese el codigo de Federacion");
        entrenador.codFederacion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la especialidad");
        entrenador.especialidad = Console.ReadLine()!;

        return entrenador;

    }

    public void MostrarEntrenador(Equipo equipoSeleccionado){
        Console.Clear();

        Console.WriteLine("ID\t Nombre\t Fecha Nacimiento\t Cuidad Origen\t Codigo Federacion\t\t Especialidad");

            foreach(var entrenador in equipoSeleccionado.entrenadores){
                Console.WriteLine($"{entrenador.id}\t {entrenador.nombre}\t {entrenador.fechaNacimiento}\t {entrenador.ciudadOrigen}\t {entrenador.codFederacion}\t\t\t {entrenador.especialidad}");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
    }
}
