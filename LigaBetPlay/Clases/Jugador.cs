namespace LigaBetPlay.Clases;

public class Jugador : Persona
{
    public string dorsal { get; set; }
    public string posicion { get; set; }
    public int nivelHabilidad { get; set; }

    public Jugador(string nombre, int id, int edad, string ciudadOrigen, string dorsal, string posicion, int nivelHabilidad) : base(nombre, id, edad, ciudadOrigen)
    {
        this.dorsal = dorsal;
        this.posicion = posicion;
        this.nivelHabilidad = nivelHabilidad;
    }
}
