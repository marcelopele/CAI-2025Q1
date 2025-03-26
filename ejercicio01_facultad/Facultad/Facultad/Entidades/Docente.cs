using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Docente : Empleado
    {

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
