using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Bedel : Empleado
    {
        //Atributos
        private string _apodo;

        //Propiedades
        public string Apodo { get => _apodo; set => _apodo = value; }


        //Métodos
        public void GetNombreCompleto()
        {

        }

        protected override string ListarEmpleados(bool listarConId)
        {
            throw new NotImplementedException();
        }


    }
}
