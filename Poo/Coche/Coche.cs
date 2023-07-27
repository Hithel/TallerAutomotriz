using System;

namespace MiCoche
{
    class Coche
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }

        public Coche(string marca, string modelo, int año, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
        }


        public void Acelerar()
        {
            Console.WriteLine("El coche está acelerando.");
        }


        public void Frenar()
        {
            Console.WriteLine("El coche está frenando.");
        }

        public void ObtenerInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Color: {Color}");
        }
    }


}