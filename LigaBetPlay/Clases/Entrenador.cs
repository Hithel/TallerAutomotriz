using LigaBetPlay.Clases;

namespace LigaBetPlay.Clases;

    public class Entrenador : Persona
    {
         public int codFederacion { get; set; }
        public string especialidad { get; set; }

        public Entrenador (string nombre, int id, int edad, string ciudadOrigen, int codFederacion,string especialidad): base (nombre,id,edad,ciudadOrigen){
        this.codFederacion = codFederacion;
        this.especialidad = especialidad;
    }
    }
