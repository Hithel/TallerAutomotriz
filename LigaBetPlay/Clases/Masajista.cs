namespace LigaBetPlay.Clases;

public class Masajista : Persona
{
    public int añosDeExp { get; set; }
    public string titulacion { get; set; }

    public Masajista(string nombre, int id, int edad, string ciudadOrigen, int añosDeExp, string titulacion) : base(nombre, id, edad, ciudadOrigen)
    {
        this.añosDeExp = añosDeExp;
        this.titulacion = titulacion;
    }
}
