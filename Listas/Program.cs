using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // List<string> Materias = new List<string>();

        // Materias.Add("Calculo");
        // Materias.Add("Español");
        // Materias.Add("Dibujo tecnico");
        // Materias.Add("Ingles");

        // Console.WriteLine("Total de elementos del a lista {0}", Materias.Count());

        String ? palabra;

        List <string> Dinosaurios = new List<string>();

        string[] Dinos = {
            "Brachiosaurus",
            "Amargasaurus",
            "Mamenchisaurus"
        };

        Dinosaurios.AddRange(Dinos);

        Console.WriteLine("Ingrese el nombre del dinosaurio");
        palabra = (Console.ReadLine()).ToLower();

        List <string> Encontrados = BuscarDinos(Dinosaurios, palabra);
        MostrarDinos(Encontrados);
        // Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ?"se encontro el Dinosaurio" : "no se encontro el Dinosaurio");

        // string ? nombre = Dinosaurios.Find(n => n.StartsWith(palabra ?? String.Empty));
        // Console.WriteLine(nombre != null ? "se encontro el Dinosaurio" : "no se encontro el Dinosaurio");

        // Encontrados = Dinosaurios.FindAll(n => n.ToLower().Contains(palabra ?? String.Empty));
        // foreach (String n in Encontrados){
        //     Console.WriteLine(n);
        // }
    }

    static  List<string> BuscarDinos(List<string> Dinosaurios, string palabra) {
        List<string> Encontrados = Dinosaurios.FindAll(n => n.ToLower().Contains(palabra ?? String.Empty));
        return Encontrados;
    }

    static void MostrarDinos(List<string> Encontrados){
        foreach (String n in Encontrados){
            Console.WriteLine(n);
        }
    }
}