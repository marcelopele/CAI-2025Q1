using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Persona
    {
        //Atributos
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;


        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        //Métodos
        protected abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }

        protected virtual void GetSaludoInformal()
        {

        }

    }
}
