using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Alumno : Persona
    {
        //Atributos
        private int _codigo;

        //Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }

        //Métodos
        protected override void GetCredencial()
        {
            throw new NotImplementedException();
        }



    }
}
