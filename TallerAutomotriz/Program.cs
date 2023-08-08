using TallerAutomotriz.Entities;
using TallerAutomotriz.Entities.Menu;
class Program
{
    static void Main(string[] args)
    {

        List<Cliente> listaClientes = new List<Cliente>();
        List<Empleados> listaEmpleado = new List<Empleados>();

        bool validacion = true;

        do{
            Console.Clear();
            Console.WriteLine("SISTEMA DE TALLER AUTOMOTRIZ\n\n");
            Console.WriteLine("1. Registro Cliente");
            Console.WriteLine("2. Registro Vehiculo");
            Console.WriteLine("3. Registro Empleado");
            Console.WriteLine("4. Operaciones Empleado");
            Console.WriteLine("5. Salir\n");
            Console.Write("Seleccione una opción: ");

            if(int.TryParse(Console.ReadLine(), out int opcion)){

                    Cliente cliente = new Cliente();
                    Vehiculos vehiculo = new Vehiculos();
                    Empleados empleado = new Empleados(); 
                    

                switch(opcion){
                    case 1:
                        Cliente newCliente = cliente.CrearCliente();
                        listaClientes.Add(newCliente);
                        cliente.MostrarClientes(listaClientes);
                        break;
                    case 2: 
                        Cliente selecionarCliente = cliente.BuscarCliente(listaClientes);
                        Vehiculos newVehiculo = vehiculo.CrearVechiculo();
                        selecionarCliente.listaVehiculos.Add(newVehiculo);
                        newVehiculo.MostrarVehiculos(selecionarCliente);
                        break;
                    case 3:
                        Empleados newEmpleado = empleado.CrearEmpleado();
                        listaEmpleado.Add(newEmpleado);
                        empleado.MostrarEmpleados(listaEmpleado);
                        break;
                    case 4:
                        Empleados selecionarEmpleado = empleado.BuscarEmpleado(listaEmpleado);
                        MenuEmpleado menuEmpleado = new MenuEmpleado();
                        menuEmpleado.EjecutarMenuEmpleado(selecionarEmpleado,listaClientes,listaEmpleado);

                        break;
                    case 5:
                        validacion = false;
                        break;

                    default: 
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                }
            }
            else {
                Console.WriteLine("Ingrese una opción valida: ");
                Console.ReadKey();
            }
        }
        while (validacion);
    }
}