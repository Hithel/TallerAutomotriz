namespace EjercicioPoo.Entidades
{
    public class Estudiante : Usuario
    {
        private string ? codigoEstudiante;

        public Usuario(string _nombreusuario, string _documento,string codigoEstudiante):base(_nombreusuario,_documento){
            this.codigoEstudiante = _codigoEstudiante;         
        }

        public string codigoEstudiante {
            get {return this.codigoEstudiante;}
            set {this.codigoEstudiante = value;}

        }
    }
}