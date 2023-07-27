using System;
using MiCoche;
class Program
{
    static void Main()
    {
    
        Coche miCoche = new Coche("Toyota", "Corolla", 2022, "Azul");

        miCoche.ObtenerInformacion();
        miCoche.Acelerar();
        miCoche.Frenar();
    }
}
