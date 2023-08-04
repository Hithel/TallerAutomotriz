namespace LigaBetPlay.Clases;

    public class Persona
    {
        public string ? nombre { get; set; }
        public int id { get; set; }
        public  DateTime fechaNacimiento { get; set; }
        public string ciudadOrigen {get; set;}

        public Persona (string nombre,int id,DateTime fechaNacimiento, string ciudadOrigen){
            this.nombre = nombre;
            this.id = id;
            this.fechaNacimiento = fechaNacimiento;
            this.ciudadOrigen = ciudadOrigen;
        }

    public Persona(){}

    public Persona CrearPersona(){
        Console.Clear();

        Persona persona = new ();

        Console.WriteLine("Ingrese la Cedula de la persona");
        persona.id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el Nombre de la persona");
        persona.nombre = Console.ReadLine()!;

        bool valid = false;

        while (!valid){
            Console.WriteLine("Ingrese la fecha de Nacimiento en dd/mm/yyyy");
            string fechaNac = Console.ReadLine()!;

            if (DateTime.TryParseExact(fechaNac, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
            persona.fechaNacimiento = fechaNacimiento.Date;
            valid = true;

            }
            else
            {
                Console.WriteLine("El formato de fecha ingresado es inválido.");
            }
        }

        Console.WriteLine("Ingrese el Nombre de la Cuidad de nacimiento");
        persona.ciudadOrigen = Console.ReadLine()!;

        return persona;

    }
}
