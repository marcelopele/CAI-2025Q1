using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Alumno : Persona
    {
        //Atributos
        private int _codigo;

        //Constructor
        public Alumno(string nombre, string apellido, DateTime _fechaNac, int codigo)
        {
            this.Codigo = codigo;
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.FechaNac = _fechaNac;
        }

        //Constructor sobrecargado => Usando un registro del txt
        public Alumno(string registro)
        {
            String[] datos = registro.Split(';');
            this.Codigo = int.Parse(datos[0]);
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.FechaNac = DateTime.Parse(datos[3]);
        }

        //Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }

        //Métodos
        protected override void GetCredencial()
        {
            throw new NotImplementedException();
        }

        public override String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.Codigo + ")";
        }

        public String[] ToStringCSV()
        {
            String[] salida = new String[4];
            salida[0] = this.Codigo.ToString();
            salida[1] = this.Nombre;
            salida[2] = this.Apellido;
            salida[3] = this.FechaNac.ToString("yyyy-MM-dd");
            return salida;
        }

    }
}
