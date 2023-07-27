using System;
using System.Collections.Generic;

namespace SistemaHobbies
{
class Usuario
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public List<string> Hobbies { get; set; }

        public Usuario(string nombre, int edad, List<string> hobbies)
        {
            Nombre = nombre;
            Edad = edad;
            Hobbies = hobbies;
        }
    }

}