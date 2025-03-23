using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal abstract class Empleado : Persona
    {
        //Atributos
        private int _legajo;
        private DateTime _fechaIngreso;

        //Propiedades
        public int Legajo { get => _legajo; set => _legajo = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }


        //Métodos
        protected override void GetCredencial()
        {

        }

        protected abstract string ListarEmpleados(bool listarConId);

    }
}
