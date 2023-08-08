namespace TallerAutomotriz.Entities;

class OrdenAprovacion : OrdenServicio
{

    public int IdAprovacion { get; set; }
    public DateTime FechaOrdenAprovacion { get; set; }

    public List<Respuestos> listaRepuestos = new List<Respuestos>();

    public OrdenAprovacion(int Id, DateTime FechaOrden, string DiagnosticoCliente, string DiagnosticoExperto, Cliente cliente, Empleados empleado, Vehiculos vehiculo,int IdAprovacion, DateTime FechaOrdenAprovacion) : base(Id, FechaOrden, DiagnosticoCliente, DiagnosticoExperto, cliente, empleado, vehiculo)
    {
        this.IdAprovacion = IdAprovacion;
        this.FechaOrdenAprovacion = FechaOrdenAprovacion;
        this.listaRepuestos = new List<Respuestos>();
    }

    public OrdenAprovacion(): base()
    {
        this.listaRepuestos = new List<Respuestos>();
    }

    public OrdenAprovacion CrearOrdenAprovacion(OrdenServicio selecionarOrden,List<Respuestos> listaRespuestos){

        OrdenAprovacion ordenAprovacion1 = new OrdenAprovacion();
        OrdenAprovacion ordenAprovacion = ordenAprovacion1;

        ordenAprovacion.Id = selecionarOrden.Id;
        ordenAprovacion.FechaOrden = selecionarOrden.FechaOrden;
        ordenAprovacion.DiagnosticoCliente = selecionarOrden.DiagnosticoCliente;
        ordenAprovacion.DiagnosticoExperto = selecionarOrden.DiagnosticoExperto;
        ordenAprovacion.cliente = selecionarOrden.cliente;
        ordenAprovacion.empleado = selecionarOrden.empleado;

        Console.WriteLine("Ingrese el numero de la orden");
        ordenAprovacion.IdAprovacion = Convert.ToInt32(Console.ReadLine());

        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Ingrese la fecha de la orden en dd/mm/yyyy");
            string fechaRegis = Console.ReadLine()!;

            if (DateTime.TryParseExact(fechaRegis, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime FechaRegistro))
            {
                ordenAprovacion.FechaOrdenAprovacion = FechaRegistro.Date;
                valid = true;

            }
            else
            {
                Console.WriteLine("El formato de fecha ingresado es inválido.");
            }
        }

        Console.WriteLine("Ingrese el numero de respuesto que desea agregar");
        int Nrepuesto = Convert.ToInt32(Console.ReadLine());

        Respuestos repuesto = new Respuestos();

        repuesto.MostrarRepuestos(listaRespuestos);

        for (int i = 0; i < Nrepuesto; i++){
            Respuestos newRepuesto = repuesto.BuscarRespuestos(listaRespuestos);
            listaRepuestos.Add(newRepuesto);
        }

        repuesto.MostrarRepuestos(listaRepuestos);
        
        return ordenAprovacion;
    }

    public void MostrarListaOrdenAprovacion(List<OrdenAprovacion> listaOrdenAprovacion){
         Console.Clear();

            Console.WriteLine("Lista de Ordenes de Aprovacion.");
            Console.WriteLine("ID Orden\t Fecha Orden\t Cliente\t Empleado");

            foreach (var OrdenServicio in listaOrdenAprovacion)
            {
                Console.WriteLine($"{OrdenServicio.Id}\t {OrdenServicio.FechaOrden}\t {OrdenServicio.cliente.Nombre}\t {OrdenServicio.empleado.Nombre}");

            }
            Console.WriteLine("\nToca enter para continuar");
            Console.ReadKey();
    }

    public void MostrarListaOrdenAprovacion(OrdenAprovacion newOrdenServicio){

        Console.Clear();

        Console.WriteLine("------------Datos de la orden------------");
        Console.WriteLine($"Nro orden: {newOrdenServicio.Id} \t Fecha: {newOrdenServicio.FechaOrden}\n");
        Console.WriteLine($"ID CLiente: {newOrdenServicio.cliente.Id} \t Nombre Cliente: {newOrdenServicio.cliente.Nombre}\n");
        Console.WriteLine($"------------Datos del Vehiculo------------");
        Console.WriteLine($"Nro Placa: {newOrdenServicio.vehiculo.Placa} \t KM: {newOrdenServicio.vehiculo.Km}\n");
        Console.WriteLine($"------------Diagnostico Cliente------------");
        Console.WriteLine($"{newOrdenServicio.DiagnosticoCliente}");
        Console.WriteLine($"------------Personal a cargo------------");
        Console.WriteLine($"CC: {newOrdenServicio.empleado.Id} \t Nombre: {newOrdenServicio.empleado.Nombre}");
        Console.WriteLine($"Especialidad: {newOrdenServicio.empleado.Especialidad}\n");
        Console.WriteLine($"------------Diagnostico Experto------------");
        Console.WriteLine($"{newOrdenServicio.DiagnosticoExperto}");

        Console.WriteLine("\nToca enter para continuar");
        Console.ReadKey();
    }

    public OrdenServicio BuscarOrdenAprovacion(List<OrdenAprovacion> listaOrdenAprovacion){

        MostrarListaOrdenAprovacion(listaOrdenAprovacion);

            Console.WriteLine("Ingrese el ID del Equipo");
            int opcion = int.Parse(Console.ReadLine()!);

            return listaOrdenAprovacion.Find(n => n.Id == opcion)!;
    }

}
