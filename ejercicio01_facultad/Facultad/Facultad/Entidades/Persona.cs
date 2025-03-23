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
        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }


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
