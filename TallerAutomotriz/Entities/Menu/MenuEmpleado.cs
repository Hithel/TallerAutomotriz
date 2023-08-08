namespace TallerAutomotriz.Entities.Menu;
public class MenuEmpleado
{
    public void EjecutarMenuEmpleado(Empleados selecionarEmpleado, List<Cliente> listaClientes, List<Empleados> listaEmpleado)
    {

        bool validacion = true;

        List<Respuestos> listaRespuestos = new List<Respuestos>();
        List<OrdenServicio> listaOrdenServicio = new List<OrdenServicio>();
        List<OrdenAprovacion> listaOrdenAprovacion = new List<OrdenAprovacion>();

        do
        {

            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTIÓN DE LIGA\n\n");
            Console.WriteLine("1. Registro de Repuestos");
            Console.WriteLine("2. Generar orden de servicio");
            Console.WriteLine("3. Generar orden de Aprovacion");
            Console.WriteLine("4. Generar Factura");
            Console.WriteLine("5. Regresar al Menu Principal\n");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Respuestos respuestos = new Respuestos();
                OrdenServicio ordenServicio = new OrdenServicio();
                OrdenAprovacion ordenAprovacion = new OrdenAprovacion(); 

                switch (opcion)
                {
                    case 1:
                        Respuestos newRepuesto = respuestos.CrearRepuesto();
                        listaRespuestos.Add(newRepuesto);
                        newRepuesto.MostrarRepuestos(listaRespuestos);

                        break;
                    case 2:
                        OrdenServicio newOrdenServicio = ordenServicio.CrearOrden(listaClientes,listaEmpleado);
                        ordenServicio.MostrarOrdenServicio(newOrdenServicio);
                        listaOrdenServicio.Add(newOrdenServicio);
                        break;
                    case 3:
                        OrdenServicio selecionarOrden = ordenServicio.BuscarOrdenServicio(listaOrdenServicio);
                        OrdenAprovacion newOrdenAprovacion = ordenAprovacion.CrearOrdenAprovacion(selecionarOrden,listaRespuestos);
                        listaOrdenAprovacion.Add(newOrdenAprovacion);
                        newOrdenAprovacion.MostrarListaOrdenAprovacion(listaOrdenAprovacion);
                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Regresar al Menu Principal");
                        validacion = false;
                        break;
                    default:
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese una opción valida: ");
                Console.ReadKey();
            }
        }
        while (validacion);
    }
}
