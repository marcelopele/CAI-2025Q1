using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Docente : Empleado
    {
        //Constructor
        public Docente(string nombre, string apellido, DateTime fechaNac, int legajo, DateTime fechaIngreso)
        {
            this.Legajo = legajo;
            this.FechaIngreso = fechaIngreso;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
        }

        //Métodos
        protected override void GetNombreCompleto()
        {

        }

        protected override string ListarEmpleados(bool listarConId)
        {
            throw new NotImplementedException();
        }


    }
}
