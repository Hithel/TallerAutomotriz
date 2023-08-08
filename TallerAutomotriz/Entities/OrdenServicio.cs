namespace TallerAutomotriz.Entities;

class OrdenServicio
{

    public int Id { get; set; }
    public DateTime FechaOrden { get; set; }
    public string ? DiagnosticoCliente { get; set; }
    public string ? DiagnosticoExperto { get; set; }

    public Cliente cliente { get; set; }
    public Empleados empleado { get; set; }
    public Vehiculos vehiculo { get; set; }

    public OrdenServicio(int Id, DateTime FechaOrden, string DiagnosticoCliente, string DiagnosticoExperto)
    {
        this.Id = Id;
        this.FechaOrden = FechaOrden;
        this.DiagnosticoCliente = DiagnosticoCliente;
        this.DiagnosticoExperto = DiagnosticoExperto;
    }

    public OrdenServicio(int Id, DateTime FechaOrden, string DiagnosticoCliente, string DiagnosticoExperto, Cliente cliente, Empleados empleado, Vehiculos vehiculo)
        : this(Id, FechaOrden, DiagnosticoCliente, DiagnosticoExperto)
    {
        this.vehiculo = vehiculo;
        this.cliente = cliente;
        this.empleado = empleado;
    }

    public OrdenServicio():base() {}

    public OrdenServicio CrearOrden(List<Cliente> listaClientes, List<Empleados> listaEmpleado){

        OrdenServicio ordenServicio = new OrdenServicio();
        Cliente cliente = new Cliente();
        Empleados empleado = new Empleados();
        Vehiculos vehiculo = new Vehiculos();

        Console.WriteLine("Ingrese el numero de la orden");
        ordenServicio.Id = Convert.ToInt32(Console.ReadLine());

        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Ingrese la fecha de la orden en dd/mm/yyyy");
            string fechaRegis = Console.ReadLine()!;

            if (DateTime.TryParseExact(fechaRegis, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime FechaRegistro))
            {
                ordenServicio.FechaOrden = FechaRegistro.Date;
                valid = true;

            }
            else
            {
                Console.WriteLine("El formato de fecha ingresado es inválido.");
            }
        }


        Cliente seleccionarCliente = cliente.BuscarCliente(listaClientes);
        ordenServicio.cliente = seleccionarCliente;

        Vehiculos selecionarVehiculo = vehiculo.BuscarVehiculos(seleccionarCliente);
        ordenServicio.vehiculo = selecionarVehiculo;

        Console.WriteLine("Ingrese el Diagnostico del CLiente");
        ordenServicio.DiagnosticoCliente = Console.ReadLine();        

        Empleados elegirEmpleado = empleado.BuscarEmpleado(listaEmpleado);
        ordenServicio.empleado = elegirEmpleado;

        Console.WriteLine("Ingrese el Diagnostico del Experto");
        ordenServicio.DiagnosticoExperto = Console.ReadLine();

        return ordenServicio;
    }


    public void MostrarOrdenServicio(OrdenServicio newOrdenServicio){

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
}
