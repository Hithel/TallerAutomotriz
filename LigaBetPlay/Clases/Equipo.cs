namespace LigaBetPlay.Clases;

    public class Equipo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List <string> propietarios { get; set; }
        public List<Jugador> jugadores { get; set; }
        public List<Masajista> masajistas { get; set; }
        public List<Entrenador> entrenadores { get; set; }

        public Equipo (string nombre, int Id){
            this.id = Id;
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

            Console.Write("\nIngrese el id del Equipo: ");
            equipo.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del Equipo");
            equipo.nombre = Console.ReadLine()!;

            return equipo;
        }

        public void MostrarEquipo(Ligas LigaSelecionada){
            Console.Clear();

            Console.WriteLine("ID\t Nombre");

            foreach(var equipos in LigaSelecionada.equiposLigas){
                Console.WriteLine($"{equipos.id}\t{equipos.nombre}");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
        }

        public Equipo BuscarEquipo(Ligas ligasSelecionada){
            
            MostrarEquipo(ligasSelecionada);


            Console.WriteLine("Ingrese el ID del Equipo");
            int opcion = int.Parse(Console.ReadLine()!);

            return ligasSelecionada.equiposLigas.Find(n => n.id == opcion)!;
        }


    }
