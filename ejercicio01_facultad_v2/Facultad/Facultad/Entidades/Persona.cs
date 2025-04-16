using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad.Entidades
{
    public abstract class Persona
    {

        //Atributos
        private String _nombre;
        private String _apellido;
        private DateTime _fechaNac;

        //Propiedades
        public String Nombre { get => _nombre; set => _nombre = value; }
        public String Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        //Métodos
        public abstract void GetCredencial();
        //abstract: se declara y no se implementa, y lo implementa el hijo
        public virtual void GetNombreCompleto()
        {
            //virtual:  se declara y se implementa, y el hijo puede reemplazar con override
            MessageBox.Show("Nombre completo: " + this.Nombre + " " + this.Apellido);
        }
        public void GetSaludoInformal()
        {
            //normal:   se declara y se implementa, y el hijo hereda el método
            MessageBox.Show("Hola " + this.Nombre);
        }


    }
}
