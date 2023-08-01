using System;
using System.Collections.Generic;

using Poo.Entidades;

internal class Program 
{
    private static void Main(string[] args)
    {
        Alumno estudiante = new Alumno("pepito");
        Console.WriteLine($"el id del estudiante {estudiante.IdAlumno}");
        Console.WriteLine($"el nombre del estudiante {estudiante.NombreAlumno}");
;    }
}