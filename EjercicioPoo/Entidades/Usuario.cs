

namespace EjercicioPoo.Entidades
{
    public class Usuario
    {
        protected string ? nombre;
        protected string ? Documento;

        public Usuario(string _nombreusuario, string _documento){
            this.Documento = _documento;
            this.nombre = _nombreusuario;            
        }

        public string Documento{
            get {return this.Documento;}
            set {this.Documento = value;}

        }

        public string NombreUsuario{
            get { return this.nombre; }
            set { this.nombre = value; }
        }
    }
}