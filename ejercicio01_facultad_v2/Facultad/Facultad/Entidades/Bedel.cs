using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Bedel:Empleado
    {
        //Atributos
        private String _apodo;

        //Propiedades
        public String Apodo { get => _apodo; set => _apodo=value; }

        //Constructor con registro del csv
        public Bedel(string registro)
        {
            String[] datos = registro.Split(';');
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.FechaNac = DateTime.Parse(datos[3]);
            this.Legajo = int.Parse(datos[4]);
            this.FechaIngreso = DateTime.Parse(datos[5]);
        }

        //Métodos
        public override void GetNombreCompleto()
        {
            base.GetNombreCompleto();
        }
        public override String ListarEmpleados(Boolean listarConId)
        {
            String salida = "";

            return salida;
        }
    }
}
