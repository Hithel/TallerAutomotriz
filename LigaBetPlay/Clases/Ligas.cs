namespace LigaBetPlay.Clases;

    public class Ligas
    {
        public string ? Nombre { get; set; }
        private int Id;
        public List<string> EquiposLigas { get; set; }

        public Ligas(string nombre, int id){
            this.Nombre = nombre;
            this.Id = id;
        }

    public Ligas(){}

    public Ligas AgregarLiga(){

        Ligas newLiga = new Ligas();

        Console.WriteLine("AGREGAR LIGA");
        Console.Write("\nIngrese el nombre de la liga: ");
        newLiga.Nombre = Console.ReadLine();

        Console.Write("\nIngrese el id de la liga: ");
        newLiga.Id = Convert.ToInt32(Console.ReadLine());

        return newLiga;
        }
    }
