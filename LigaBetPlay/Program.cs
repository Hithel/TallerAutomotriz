using LigaBetPlay.Clases.Menus;
using LigaBetPlay.Clases;
class Program
{
    static void Main(string[] args)
    {
        MenuPrincipal();
    }

    static void MenuPrincipal(){

        List<Ligas> listLigas = new List<Ligas>();

        bool validacion = true;

        do{
            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTIÓN DE LIGA\n\n");
            Console.WriteLine("1. Registro Plantel");
            Console.WriteLine("2. Consultar Datos");
            Console.WriteLine("3. crear Liga");
            Console.WriteLine("4. Salir\n");
            Console.Write("Seleccione una opción: ");

            if(int.TryParse(Console.ReadLine(), out int opcion)){
                switch(opcion){
                    case 1:
                        MenuPlantel menuPlantel = new MenuPlantel();
                        menuPlantel.EjecutarMenuPlantel(listLigas);
                        break;
                    case 2: 
                        MenuBuscar menuPrinci = new MenuBuscar();
                        menuPrinci.EjecutarMenuBuscar();
                        break;
                    case 3:
                        Ligas newLiga = new Ligas();
                        listLigas.Add(newLiga.AgregarLiga());
                        newLiga.MostrarLigas(listLigas);

                        break;
                    case 4:
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