namespace LigaBetPlay.Clases;

    public class Ligas
    {
        public string ? Nombre { get; set; }
        private int Id;
        private List<Equipo> EquiposLigas = new List<Equipo> ();

        public List<Equipo> equiposLigas
        {
            get{ return this.EquiposLigas; }
            set{this.EquiposLigas = value;}
        }

        public Ligas(string nombre, int id){
            Nombre = nombre;
            Id = id;
        }

    public Ligas(){}

    public Ligas AgregarLiga(){

        Ligas newLiga = new Ligas();

        Console.WriteLine("AGREGAR LIGA");
        Console.Write("\nIngrese el id de la liga: ");
        newLiga.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese el nombre de la liga: ");
        newLiga.Nombre = Console.ReadLine();


        return newLiga;
        }
    
    public void MostrarLigas(List<Ligas> listLigas){
        Console.Clear();
        Console.WriteLine("ID\t Nombre");
        foreach (var liga in listLigas)
        {
            Console.WriteLine($"{liga.Id}\t{liga.Nombre}");
        }
        Console.WriteLine("\nToca enter para continuar.");
        Console.ReadKey();

    }

    public Ligas BuscarLigas(List<Ligas> listLigas){
        MostrarLigas(listLigas); 

        Console.WriteLine("Ingrese el ID de la liga");
        int opcion = int.Parse(Console.ReadLine());

        return listLigas.Find(n => n.Id == opcion);
    }
}
