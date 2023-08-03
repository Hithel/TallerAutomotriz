namespace LigaBetPlay.Clases;

    public class Equipo
    {
        public string nombre { get; set; }
        public List <string> propietarios { get; set; }
        public List<Jugador> jugadores { get; set; }
        public List<Masajista> masajistas { get; set; }
        public List<Entrenador> entrenadores { get; set; }

        public Equipo (string nombre){
            this.nombre = nombre;
            this.propietarios = new List<string>();
            this.jugadores = new List<Jugador>();
            this.masajistas = new List<Masajista>();
            this.entrenadores = new List<Entrenador>();
        }
        public Equipo(){
            this.propietarios = new List<string>();
            this.jugadores = new List<Jugador>();
            this.masajistas = new List<Masajista>();
            this.entrenadores = new List<Entrenador>();
        }
        
        public Equipo AgregarEquipo(){

            Equipo equipo = new Equipo();

            Console.WriteLine("Ingrese el Nombre del Equipo");
            equipo.nombre = Console.ReadLine();

            return equipo;
        }
    }
