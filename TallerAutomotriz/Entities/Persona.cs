namespace TallerAutomotriz.Entities;
public class Persona
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public int Celular { get; set; }
    public string? Email { get; set; }

    public Persona(int Id, string Nombre, string Apellidos, int Celular, string Email)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
        this.Celular = Celular;
        this.Email = Email;
    }

    public Persona(){}

    
}
