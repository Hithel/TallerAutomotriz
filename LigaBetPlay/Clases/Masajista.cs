namespace LigaBetPlay.Clases;

public class Masajista : Persona
{
    public int añosDeExp { get; set; }
    public string titulacion { get; set; }

    public Masajista(string nombre, int id, DateTime fechaNacimiento, string ciudadOrigen, int añosDeExp, string titulacion) : base(nombre, id, fechaNacimiento, ciudadOrigen)
    {
        this.añosDeExp = añosDeExp;
        this.titulacion = titulacion;
    }
}
