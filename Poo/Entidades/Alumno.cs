using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Entidades
{
    public class Alumno
    {
        private string ? idAlumno;
        private string ? nombreAlumno; 

        public Alumno(string _nombreAlumno){
            this.idAlumno = Guid.NewGuid().ToString();
            this.nombreAlumno = _nombreAlumno;            
        }

        public string IdAlumno{
            get {
                return this.idAlumno;
            }
        }

        public string NombreAlumno{
            get { return this.nombreAlumno; }
            set { this.nombreAlumno = value; }
        }
    }
}